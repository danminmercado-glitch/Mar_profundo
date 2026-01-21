using UnityEngine;
using TMPro;

public class TextoInteraccion : MonoBehaviour
{
    public GameObject canvas;
    public GameObject texto; 
    public GameObject panel;

    private void OnTriggerEnter(Collider other)
    {
        if (canvas != null)
        {
            canvas.SetActive(true);
            panel.SetActive(false);
            texto.SetActive(false);

        }
        if (other.CompareTag("Player"))
        {
            texto.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            texto.SetActive(false);
        }
    }
}