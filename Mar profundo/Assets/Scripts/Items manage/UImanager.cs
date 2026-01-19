using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
   public static UImanager Instance;

    [SerializeField] private TextMeshProUGUI Historytext;
    [SerializeField] private TextMeshProUGUI Botonuno;
    [SerializeField] private TextMeshProUGUI Botondos;
    public GameObject panel;

    private float Ahogamiento;
    private float AhogamientoMaximo = 10;
    public Image BarradeAhogamiento;



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else { Destroy(this); }
        ActualizarBarradeAhogamiento();

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

        ActualizarBarradeAhogamiento();
    }

    public void respuestBotonDos()
    {

        panel.SetActive(false);

        ActualizarBarradeAhogamiento();
    }

    private void ActualizarBarradeAhogamiento()
    {
        float CantidaddeLlenadodeBarra = Ahogamiento / AhogamientoMaximo;
        BarradeAhogamiento.fillAmount = CantidaddeLlenadodeBarra;
    }



}

