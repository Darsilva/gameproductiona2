using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{
    public PlayerControls controls;
    private Vector2 moveInput;
    public float jumpForce = 5f;
    private Rigidbody rb;
    private bool isGrounded = true;
    public float movementSpeed = 5f;
    private AudioSource audioSource;
    public GameObject collisionPrefab;
    public AudioClip collisionSound;
    public Vector3 respawnPosition;
    private void Awake()
    {
        controls = new PlayerControls();
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        // Movement
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;

        // Jump
        controls.Player.Jump.performed += ctx => Jump();

        //Respawn
        controls.Player.Respawn.performed += ctx => Respawn();
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

    private void Respawn()
    {
        // Reset the player's position to the respawn point
        transform.position = respawnPosition;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            foreach (ContactPoint contact in collision.contacts)
            {
                GameObject instantiatedObject = Instantiate(collisionPrefab, contact.point, Quaternion.identity);
                Destroy(instantiatedObject, 5f);
                break;
            }
            if (collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound);
            }
        }

    }
}