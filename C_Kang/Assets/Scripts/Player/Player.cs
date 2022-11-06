using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;     

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 30.0f;

    bool isMove = false;

    PlayerInputSystem input;
    Animator ani;
    Rigidbody rigid;
    Warrior warrior;
    WaitForSeconds q_Cooltime;
    
    Vector3 clickPositon;

    private void Awake()
    {
        input = new PlayerInputSystem();
        q_Cooltime = new WaitForSeconds(2.0f);
        ani = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        warrior = GetComponent<Warrior>();
    }

    private void OnEnable()
    {
        input.Player.Enable();
        input.Player.Move.performed += OnMouseClick;
        input.Player.Dive.performed += OnDive;
        input.Player.Attack.performed += OnAttack;
        input.Player.Q_Skill.performed += On_Q;
        input.Player.W_Skill.performed += On_W;
        input.Player.E_Skill.performed += On_E;
        input.Player.R_Skill.performed += On_R;
        input.Player.Pickup.performed += OnItemPickup;
    }

    private void OnDisable()
    {
        input.Player.Pickup.performed -= OnItemPickup;
        input.Player.R_Skill.performed -= On_R;
        input.Player.E_Skill.performed -= On_E;
        input.Player.W_Skill.performed -= On_W;
        input.Player.Q_Skill.performed -= On_Q;
        input.Player.Attack.performed -= OnAttack;
        input.Player.Dive.performed -= OnDive;
        input.Player.Move.performed -= OnMouseClick;
        input.Player.Disable();
    }

    private void FixedUpdate()
    {
        if (isMove)
        {
            Move();
        }
    }

    private void OnMouseClick(InputAction.CallbackContext _)
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

        if (Physics.Raycast(ray, out RaycastHit hit, 100.0f, LayerMask.GetMask("Ground")))
        // GetMask로는 찾아지고 NameToLayer로는 못찾는다??
        {
            clickPositon = hit.point;
            isMove = true;
        }
    }

    void Move()
    {
        Vector3 dir = clickPositon - transform.position;
        if (dir.sqrMagnitude > 0.1f)
        {
            rigid.MovePosition(rigid.position + moveSpeed * Time.fixedDeltaTime * dir.normalized);
            ani.SetBool("IsMove", isMove);
        }
        else
        {
            isMove = false;
            ani.SetBool("IsMove", isMove);
        }
        rigid.rotation = Quaternion.Slerp(rigid.rotation, Quaternion.LookRotation(dir), rotateSpeed * Time.fixedDeltaTime);
    }

    private void OnAttack(InputAction.CallbackContext obj)
    {
    }

    private void OnDive(InputAction.CallbackContext _)
    {
        ani.SetTrigger("Dive");
        isMove = false;
        ani.SetBool("IsMove", isMove);
        input.Player.Disable();
    }
    
    public void OffDive()
    {
        input.Player.Enable();
    }

    IEnumerator Q_Cooldown()
    {
        input.Player.Q_Skill.performed -= On_Q;
        yield return q_Cooltime;
        input.Player.Q_Skill.performed += On_Q;
    }

    private void On_Q(InputAction.CallbackContext _)
    {
        Vector3 dir = transform.rotation * Vector3.forward;
        Quaternion.LookRotation(dir);
        clickPositon = transform.position;
        warrior.Q_Skill();
        StartCoroutine(Q_Cooldown());
    }

    private void On_W(InputAction.CallbackContext _)
    {
        warrior.W_Skill();
    }

    private void On_E(InputAction.CallbackContext _)
    {
        warrior.E_Skill();
    }

    private void On_R(InputAction.CallbackContext _)
    {
        if (warrior.Rage == 100)
        {
            warrior.R_Skill();
        }
    }

    private void OnItemPickup(InputAction.CallbackContext _)
    {
        // 아이템 획득 버튼
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(clickPositon, 0.2f);
    }
}
