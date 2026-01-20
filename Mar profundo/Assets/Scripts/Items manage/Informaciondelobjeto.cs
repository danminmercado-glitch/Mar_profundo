using UnityEngine;

[CreateAssetMenu(fileName = "Informaciondelobjeto", menuName = "Objetos/Informaciondelobjeto")]
public class Informaciondelobjeto : ScriptableObject
{
    public string Historia;
    public string Opcionuno;
    public string Opciondos;

    public int Ahogamiento_opcion1;
    public int Ahogamiento_opcion2;
    public int evasion_opcion1;
    public int evasion_opcion2;
    public int conciencia_opcion1;
    public int conciencia_opcion2;
    public int control_opcion1;
    public int control_opcion2;
}
