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
    public Informaciondelobjeto infoobjeto;
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

    public void UIUpdate(Informaciondelobjeto _infoobjeto)
    {
       

    
        infoobjeto = _infoobjeto;
        panel.SetActive (true);
        Historytext.text = _infoobjeto.Historia;

        Botonuno.text = _infoobjeto.Opcionuno;
        Botondos.text = _infoobjeto.Opciondos;



    }

    public void respuestaBotonUno()
    {
        panel.SetActive(false);
        Ahogamiento += infoobjeto.Ahogamiento_opcion1;
        ActualizarBarradeAhogamiento();
    }

    public void respuestBotonDos()
    {

        panel.SetActive(false);
        Ahogamiento += infoobjeto.Ahogamiento_opcion2;
        ActualizarBarradeAhogamiento();
    }

    private void ActualizarBarradeAhogamiento()
    {
        float CantidaddeLlenadodeBarra = Ahogamiento / AhogamientoMaximo;
        BarradeAhogamiento.fillAmount = CantidaddeLlenadodeBarra;
    }



}

