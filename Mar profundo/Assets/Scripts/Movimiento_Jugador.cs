using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerAnimationControler animControler;
    [SerializeField] private float moveForce = 10f;
    [SerializeField] private float jumpForce = 265f;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float rotationSpeed = 10f;

    private PlayerInput playerInput;
    private Vector2 input;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        rb.freezeRotation = true; // Evita que el personaje se voltee
    }

    private void Update()
    {
        input = playerInput.actions["Move"].ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(input.x, 0f, input.y);
        rb.AddForce(movement * moveForce, ForceMode.Force);
        animControler.cambiarAnimacion("Caminar");

        Vector3 camForward = cameraTransform.forward;
        Vector3 camRight = cameraTransform.right;

        camForward.y = 0f;
        camRight.y = 0f;

        camForward.Normalize();
        camRight.Normalize();

        Vector3 moveDirection = camForward * input.y + camRight * input.x;

        if (moveDirection.magnitude > 0.1f)
        {
            rb.AddForce(moveDirection * moveForce, ForceMode.Force);

            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            rb.MoveRotation(
                Quaternion.Slerp(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime)
            );
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}