using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
   public static UImanager Instance;

    [SerializeField] private TextMeshProUGUI Historytext;
    [SerializeField] private TextMeshProUGUI Botonuno;
    [SerializeField] private TextMeshProUGUI Botondos;
    [SerializeField] public int evasion;
    [SerializeField] public int conciencia;
    [SerializeField] public int control;
    [SerializeField] public int evasion_opcion1;
    [SerializeField] public int evasion_opcion2;
    [SerializeField] public int conciencia_opcion1;
    [SerializeField] public int conciencia_opcion2;
    [SerializeField] public int control_opcion1;
    [SerializeField] public int control_opcion2;
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
        evasion = evasion + evasion_opcion1;
        conciencia = conciencia + conciencia_opcion1;
        evasion = evasion + evasion_opcion1;
        ActualizarBarradeAhogamiento();
    }

    public void respuestBotonDos()
    {

        panel.SetActive(false);
        evasion = evasion + evasion_opcion2;
        conciencia = conciencia + conciencia_opcion2;
        control = control + control_opcion2;
        ActualizarBarradeAhogamiento();
    }

    private void ActualizarBarradeAhogamiento()
    {
        float CantidaddeLlenadodeBarra = Ahogamiento / AhogamientoMaximo;
        BarradeAhogamiento.fillAmount = CantidaddeLlenadodeBarra;
    }



}

