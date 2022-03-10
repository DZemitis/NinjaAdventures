using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    [FormerlySerializedAs("moveSpeed")] public float MoveSpeed;
    [FormerlySerializedAs("jumpForce")] public float JumpForce;
    private Animator Animator;
    private Vector3 MoveDirection;
    [FormerlySerializedAs("jump")] public AudioSource Jump;
    [FormerlySerializedAs("jumpUnderworld")] public AudioSource JumpUnderworld;
    private bool _isjumping;
    private bool _isGrounded;

    [SerializeField] private Rigidbody playerBody;

    void Start()
    {
        Animator = GetComponent<Animator>();
        playerBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoveDirection = new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, playerBody.velocity.y, 0f);
        transform.LookAt(transform.position + new Vector3(MoveDirection.x, 0, 0));
        playerBody.velocity = MoveDirection;

        if (Input.GetButton("Horizontal"))
        {
            Animator.SetBool("isRunning", true);
        }
        else
        {
            Animator.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Animator.SetBool("IsJumping", true);
            playerBody.velocity = Vector3.up * JumpForce;
            Jump.Play();
            JumpUnderworld.Play();
        }
        else
        {
            Animator.SetBool("IsJumping", false);
        }
    }

    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.5f);
    }

}
