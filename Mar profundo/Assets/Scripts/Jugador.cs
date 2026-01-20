using UnityEngine;
using UnityEngine.InputSystem;


public class Jugador : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;

    [SerializeField]
    private Transform _cameraTransform;

    private Rigidbody _rb;
    private Vector2 _moveInput;
    public int miNivel = 1;
    public float BarraAhogamiento;
    public int evasion = 0;
    public int conciencia = 0;
    public int control = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = _cameraTransform.forward * _moveInput.y + _cameraTransform.right * _moveInput.x;
        move.y = 0f;
        _rb.AddForce(move.normalized * _speed, ForceMode.VelocityChange);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            GuardarDatos();
        }

        // Cargar al presionar la tecla L
        if (Input.GetKeyDown(KeyCode.L))
        {
            CargarDatos();
        }
    }
    void GuardarDatos()
    {
        // Creamos una nueva instancia de PlayerData con los valores actuales
        DatosJugador datosAGuardar = new DatosJugador(miNivel, BarraAhogamiento, transform.position, evasion, conciencia, control);

        // Llamamos al sistema estático
        SaveSystem.SaveGame(datosAGuardar);
    }

    void CargarDatos()
    {
        // Pedimos los datos al sistema
        DatosJugador datosCargados = SaveSystem.LoadGame();

        if (datosCargados != null)
        {
            // Actualizamos las variables del juego con lo que cargamos
            miNivel = datosCargados.nivel;
            BarraAhogamiento = datosCargados.ahogamiento;
            transform.position = datosCargados.posicion;
            Debug.Log("Datos actualizados: Nivel " + miNivel);
        }
    }
}