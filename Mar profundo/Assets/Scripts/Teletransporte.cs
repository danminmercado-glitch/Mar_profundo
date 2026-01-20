using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform destino;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }

            other.transform.position = destino.position;
        }
    }
}