using UnityEngine;
using UnityEngine.InputSystem;
//Codigo para el movimiento de el jugador usando el sitema de Input de Unity
public class PlayerMovement : MonoBehaviour
{
    //Declarar variables
    public Rigidbody rb;
    [SerializeField] private float upForce = 265f, force = 10f;
    private PlayerInput playerInput;
    private Vector2 input;

    //Toma el rigidbody en una variable para un facil uso y el componente de Input
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    //Ajusta el input con los pulsados de botones
    private void Update()
    {
        input = playerInput.actions["Move"].ReadValue<Vector2>();

    }

    //Fuerzas de movimiento horizontal en FixedUpdate ya que maneja mejores las fisicas
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(input.x, 0f) * force);
    }

    //Sincronizar el imput de jump con el script y hace que solo salte en la face performed cuando se presiona el boton
    public void Jump(InputAction.CallbackContext callbackContext)
    {
        if(callbackContext.performed)
        {
            rb.AddForce(Vector2.up * upForce);
        }
    }

}
