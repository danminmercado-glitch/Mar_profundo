using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerAnimationControler animControler;
    [SerializeField] private float moveForce = 10f;
    [SerializeField] private float jumpForce = 265f;

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
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}