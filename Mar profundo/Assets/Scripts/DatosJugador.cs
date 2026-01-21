using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

[System.Serializable] 
public class DatosJugador : MonoBehaviour
{
    public int nivel;
    public float Ahogamiento;
    public Vector3 posicion;
    public int evasion;
    public int conciencia;
    public int control;
    public bool finalbueno;
    // Constructor para inicializar datos 
    public DatosJugador(int _nivel, float _ahogamiento, Vector3 _posicion, int _evasion = 0, int _conciencia = 0, int _control = 0, bool finalbueno = false)
    {
        nivel = _nivel;
        Ahogamiento = _ahogamiento;
        posicion = _posicion;
        evasion = _evasion;
        conciencia = _conciencia;
        control = _control;
        this.finalbueno = finalbueno;
    }
    private void Update()
    {
        if(Ahogamiento <= 5)
        {
            finalbueno = true;
        }
        else if (Ahogamiento > 10)
        {
            Destroy(gameObject.GetComponent<Jugador>());
        }
    }
    public float ahogamiento { get; internal set; }
}

