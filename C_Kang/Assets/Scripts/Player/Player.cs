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
    Collider bodyCollider;
    
    Vector3 clickPositon;

    private void Awake()
    {
        input = new PlayerInputSystem();
        ani = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        bodyCollider = GetComponent<Collider>();
    }

    private void OnEnable()
    {
        input.Player.Enable();
        input.Player.Move.performed += OnMouseClick;
        input.Player.Dive.performed += OnDive;
    }

    private void OnDisable()
    {
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
        rigid.rotation = Quaternion.Slerp(rigid.rotation, Quaternion.LookRotation(dir.normalized), rotateSpeed * Time.fixedDeltaTime);
    }

    private void OnDive(InputAction.CallbackContext _)
    {
        isMove = false;
        ani.SetTrigger("Dive");
        input.Player.Disable();
    }
    
    public void OffDive()
    {
        input.Player.Enable();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(clickPositon, 0.2f);
    }
}
