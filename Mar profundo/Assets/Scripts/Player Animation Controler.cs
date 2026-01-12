using System.IO;
using UnityEngine;

public class PlayerAnimationControler : MonoBehaviour
{
    public Animator anim;
    private string AnimacionActual;


    private void Update()
    {
        if (Input  .GetKeyDown ( KeyCode.W ) )
        {
            cambiarAnimacion("Caminar");
        }
        if ( Input .GetKeyUp  ( KeyCode.W  ))
        {
            cambiarAnimacion("Idle");
        }

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
