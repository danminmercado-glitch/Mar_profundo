using UnityEngine;

[System.Serializable] 
public class DatosJugador
{
    public int nivel;
    public float salud;
    public Vector3 posicion;

    // Constructor para inicializar datos 
    public DatosJugador(int _nivel, float _ahogamiento, Vector3 _posicion)
    {
        nivel = _nivel;
        salud = _ahogamiento;
        posicion = _posicion;
    } 
}