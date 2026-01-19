using UnityEngine;

[System.Serializable] 
public class DatosJugador
{
    public int nivel;
    public float salud;
    public Vector3 posicion;
    public int evasion;
    public int conciencia;
    public int control;
    public bool prog_narrativo;
    public bool bucle;
    public bool final_desbloqueado;

    // Constructor para inicializar datos 
    public DatosJugador(int _nivel, float _ahogamiento, Vector3 _posicion, int _evasion = 0, int _conciencia = 0, int _control = 0, bool _prog_narrativo = false, bool _bucle = false, bool _final_desbloqueado = false)
    {
        nivel = _nivel;
        salud = _ahogamiento;
        posicion = _posicion;
    }

    public float ahogamiento { get; internal set; }
}