using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;

public class Warrior : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 30.0f;

    bool isDive = false;
    bool isSkill_Q = false;
    bool isSkill_W = false;
    bool isSkill_E = false;
    bool isSkill_R = false;

    PlayerInputSystem input;
    Animator ani;
    Rigidbody rigid;
    Transform swordPosition;
    Collider swordCollider;

    Vector3 clickPositon;

    public Action onSkill_Q;
    
    Action updateState;
    
    PlayerState state = PlayerState.Run;

    enum PlayerState
    {
        Idle = 0,
        Run,
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
        swordPosition = GetComponentInChildren<SwordPosition>().transform;
        swordCollider = swordPosition.GetChild(1).GetComponent<Collider>();
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

    void Update_Die()
    {

    }

    private void OnDive(InputAction.CallbackContext _)
    {
        if(!isDive)
        {
            StartCoroutine(DiveCoroutine());
        }
    }

    IEnumerator DiveCoroutine()
    {
        isDive = true;
        input.Player.Disable();
        ani.SetTrigger("Dive");

        float delay = 1.6f;
        while (delay > 0)
        {
            yield return null;
            delay -= Time.deltaTime;
        }
        isDive = false;
        input.Player.Enable();
    }

    private void OnAttack(InputAction.CallbackContext _)
    { 
        
    }

    private void On_Q(InputAction.CallbackContext _)
    {
        if(!isSkill_Q)
        {
            StartCoroutine(Q_Coroutine());
            onSkill_Q?.Invoke();
        }
    }

    IEnumerator Q_Coroutine()
    {
        // 쿨타임 시작 호출 델리게이트 연결 (UI)
        isSkill_Q = true;
        swordCollider.enabled = true;
        input.Player.Disable();
        ani.SetTrigger("QTrigger");

        float cooldown = 1.2f;
        float delay = 1.8f;
        while(cooldown > 0)
        {
            while (delay > 0)
            {
                yield return null;
                delay -= Time.deltaTime;
            }
            if (isSkill_Q)
            {
                swordCollider.enabled = false;
                input.Player.Enable();
            }
            yield return null;
            cooldown -= Time.deltaTime;
        }
        isSkill_Q = false;
    }

    private void On_W(InputAction.CallbackContext _)
    {
    }

    private void On_E(InputAction.CallbackContext _)
    {
    }

    private void On_R(InputAction.CallbackContext _)
    {
        
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
