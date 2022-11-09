using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 30.0f;

    PlayerInputSystem input;
    Animator ani;
    Rigidbody rigid;

    Vector3 clickPositon;

    Warrior warrior;
    public Action onQ_Skill;
    Action updateState;
    
    PlayerState state = PlayerState.Run;

    enum PlayerState
    {
        Idle = 0,
        Run,
        Dive,
        Attack,
        Skill,
        Die
    }

    PlayerState State
    {
        get => state;
        set
        {
            if (state != value)
            {
                switch (state)
                {
                    case PlayerState.Idle:
                        break;
                    case PlayerState.Run:
                        ani.applyRootMotion = true;
                        ani.SetBool("IsMove", false);
                        break;
                    case PlayerState.Dive:
                        break;
                    case PlayerState.Attack:
                        break;
                    case PlayerState.Skill:
                        break;
                    case PlayerState.Die:
                        break;
                    default:
                        break;
                }
                state = value;
                switch (state)
                {
                    case PlayerState.Idle:
                        updateState = Update_Idle;
                        break;
                    case PlayerState.Run:
                        ani.applyRootMotion = false;
                        ani.SetBool("IsMove", true);
                        updateState = Update_Run;
                        break;
                    case PlayerState.Dive:
                        input.Player.Disable();
                        ani.SetTrigger("Dive");
                        updateState = Update_Dive;
                        break;
                    case PlayerState.Attack:
                        updateState = Update_Attack;
                        break;
                    case PlayerState.Skill:
                        input.Player.Disable();
                        updateState = Update_Skill;
                        break;
                    case PlayerState.Die:
                        updateState = Update_Die;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private void Awake()
    {
        input = new PlayerInputSystem();
        ani = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        
        warrior = GetComponent<Warrior>();
    }

    private void Start()
    {
        State = PlayerState.Idle;
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
        updateState();
    }

    private void OnMouseClick(InputAction.CallbackContext _)
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

        if (Physics.Raycast(ray, out RaycastHit hit, 100.0f, LayerMask.GetMask("Ground")))
        // GetMask로는 찾아지고 NameToLayer로는 못찾는다??
        {
            clickPositon = hit.point;
            State = PlayerState.Run;
        }
    }

    private void OnAttack(InputAction.CallbackContext _)
    { 
        
    }

    private void OnDive(InputAction.CallbackContext _)
    {
        State = PlayerState.Dive;
    }

    void Update_Idle()
    {

    }

    void Update_Run()
    {
        Vector3 dir = clickPositon - transform.position;

        if (dir.sqrMagnitude > 0.1f)
            rigid.MovePosition(rigid.position + moveSpeed * Time.fixedDeltaTime * dir.normalized);
        else
            State = PlayerState.Idle;
        
        rigid.rotation = Quaternion.Slerp(rigid.rotation, Quaternion.LookRotation(dir), rotateSpeed * Time.fixedDeltaTime);
    }

    void Update_Dive()
    {
        State = PlayerState.Dive;
    }

    void Update_Attack()
    {

    }

    void Update_Skill()
    {

    }
    void Update_Die()
    {

    }

    private void On_Q(InputAction.CallbackContext _)
    {
        onQ_Skill?.Invoke();
        State = PlayerState.Skill;
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

        //float delay = 3f; // 원하는 지연시간(초)
        //while (delay > 0f)
        //{
        //    yield return null;
        //    delay -= Time.deltaTime;
        //}
    }

    private void OnItemPickup(InputAction.CallbackContext _)
    {
        // 아이템 획득 버튼
    }

    public void AnimationOffEvent()
    {
        input.Player.Enable();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(clickPositon, 0.2f);
    }
}
