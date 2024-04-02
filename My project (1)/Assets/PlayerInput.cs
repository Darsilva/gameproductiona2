using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{
    public PlayerControls controls;
    private Vector2 moveInput;
    public float jumpForce = 5f;
    private Rigidbody rb;
    private bool isGrounded = true;
    public float movementSpeed = 5f;
    private void Awake()
    {
        controls = new PlayerControls();
        rb = GetComponent<Rigidbody>();
        // Movement
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;

        // Jump
        controls.Player.Jump.performed += ctx => Jump();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    private void Update()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y) * Time.deltaTime * movementSpeed;
        transform.Translate(move, Space.World);
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground")) // Floor have tag "ground"
        {
            isGrounded = true;
        }
    }
}