using System.IO;
using UnityEngine;

public class PlayerAnimationControler : MonoBehaviour
{
    public Animator anim;
    private string AnimacionActual;


    private void Update()
    {
    

    }

    public void cambiarAnimacion(string nuevaAnimacion)
    {
        if (AnimacionActual != nuevaAnimacion)
        {
            AnimacionActual = nuevaAnimacion;
            anim.CrossFade(nuevaAnimacion, 0);

        }
    }
}
