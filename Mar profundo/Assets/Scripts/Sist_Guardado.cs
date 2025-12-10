using UnityEngine;
using System.IO;
public static class SaveSystem
{
    // Definimos la ruta donde se guardará el archivo. 
    // persistentDataPath es una carpeta segura que Unity asigna en cualquier plataforma (PC, Android, iOS).
    private static string path = Application.persistentDataPath + "/savefile.json";

    public static void SaveGame(DatosJugador data)
    {
        // 1. Convertir el objeto DatosJugadir a texto JSON
        string json = JsonUtility.ToJson(data, true); 

        // 2. Escribir ese texto en un archivo
        File.WriteAllText(path, json);

        Debug.Log("Juego Guardado en: " + path);
    }

    public static DatosJugador LoadGame()
    {
        // 1. Verificar si el archivo existe
        if (File.Exists(path))
        {
            // 2. Leer el contenido del archivo
            string json = File.ReadAllText(path);

            // 3. Convertir el texto JSON de vuelta a un objeto DatosJugador
            DatosJugador data = JsonUtility.FromJson<DatosJugador>(json);

            Debug.Log("Juego Cargado correctamente.");
            return data;
        }
        else
        {
            Debug.LogWarning("No se encontró archivo de guardado.");
            return null;
        }
    }
}