using UnityEngine;

public class ItemInteractor : MonoBehaviour
{
    public bool Dorian;//esta variable va a decir si esta dentro o fuera de la zona 
    public Informaciondelobjeto objeto;
    private void Update()
    {
        if (Dorian)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(objeto.Historia);
                Debug.Log(objeto.Opcionuno);
                Debug.Log(objeto.Opciondos);


            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject .CompareTag( "Player"))
        {
            Dorian = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Dorian = false;
        }

    }
}
