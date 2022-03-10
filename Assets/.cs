//using UnityEngine;

////This script requires you to have setup your animator with 3 parameters, "InputMagnitude", "InputX", "InputZ"
////With a blend tree to control the inputmagnitude and allow blending between animations.
//[RequireComponent(typeof(CharacterController))]
//public class MovementInput : MonoBehaviour
//{

//    public float Velocity;
//    [Space]

//    public float InputX;
//    public Vector3 DesiredMoveDirection;
//    public bool BlockRotationPlayer;
//    public float DesiredRotationSpeed = 0.1f;
//    public Animator Anim;
//    public float Speed;
//    public float AllowPlayerRotation = 0.1f;
//    public Camera Camera;
//    public CharacterController Controller;
//    public bool IsGrounded;

//    [Header("Animation Smoothing")]
//    [Range(0, 1f)]
//    public float HorizontalAnimSmoothTime = 0.2f;
//    [Range(0, 1f)]
//    public float VerticalAnimTime = 0.2f;
//    [Range(0, 1f)]
//    public float StartAnimTime = 0.3f;
//    [Range(0, 1f)]
//    public float StopAnimTime = 0.15f;

//    public float verticalVel;
//    private Vector3 moveVector;

//    // Use this for initialization
//    void Start()
//    {
//        Anim = this.GetComponent<Animator>();
//        Camera = Camera.main;
//        Controller = this.GetComponent<CharacterController>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        InputMagnitude();

//        IsGrounded = Controller.IsGrounded;
//        if (IsGrounded)
//        {
//            verticalVel -= 0;
//        }
//        else
//        {
//            verticalVel -= 1;
//        }
//        moveVector = new Vector3(0, verticalVel * .2f * Time.deltaTime, 0);
//        Controller.Move(moveVector);


//    }

//    void PlayerMoveAndRotation()
//    {
//        InputX = Input.GetAxis("Horizontal");

//        var camera = Camera.main;
//        var forward = Camera.transform.forward;
//        var right = Camera.transform.right;

//        forward.y = 0f;
//        right.y = 0f;

//        forward.Normalize();
//        right.Normalize();

//        DesiredMoveDirection = right * InputX;

//        if (BlockRotationPlayer == false)
//        {
//            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(DesiredMoveDirection), DesiredRotationSpeed);
//            Controller.Move(DesiredMoveDirection * Time.deltaTime * Velocity);
//        }
//    }

//    public void LookAt(Vector3 pos)
//    {
//        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(pos), DesiredRotationSpeed);
//    }

//    public void RotateToCamera(Transform t)
//    {

//        var camera = Camera.main;
//        var forward = Camera.transform.forward;
//        var right = Camera.transform.right;

//        DesiredMoveDirection = forward;

//        t.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(DesiredMoveDirection), DesiredRotationSpeed);
//    }

//    void InputMagnitude()
//    {
//        //Calculate Input Vectors
//        InputX = Input.GetAxis("Horizontal");


//        //Anim.SetFloat ("InputZ", InputZ, VerticalAnimTime, Time.deltaTime * 2f);
//        //Anim.SetFloat ("InputX", InputX, HorizontalAnimSmoothTime, Time.deltaTime * 2f);

//        //Calculate the Input Magnitude

//        //Physically move player

//        if (Speed > AllowPlayerRotation)
//        {
//            Anim.SetFloat("Blend", Speed, StartAnimTime, Time.deltaTime);
//            PlayerMoveAndRotation();
//        }
//        else if (Speed < AllowPlayerRotation)
//        {
//            Anim.SetFloat("Blend", Speed, StopAnimTime, Time.deltaTime);
//        }
//    }
//}
