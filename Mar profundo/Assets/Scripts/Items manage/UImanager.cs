using UnityEngine;
using TMPro;
public class UImanager : MonoBehaviour
{
   public static UImanager Instance;

    [SerializeField] private TextMeshProUGUI Historytext;
    [SerializeField] private TextMeshProUGUI Botonuno;
    [SerializeField] private TextMeshProUGUI Botondos;
    public GameObject panel;



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else { Destroy(this); }


    }

    public void UIUpdate(string historytext,string botonunotext,string botondostext)
    {
        panel.SetActive (true);
        Historytext.text = historytext;

        Botonuno.text = botonunotext;
        Botondos.text = botondostext;



    }

    public void respuestaBotonUno()
    {
        panel.SetActive(false);

    }

    public void respuestBotonDos()
    {

        panel.SetActive(false);
    }



}

