using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Authorize"))
        {
            other.gameObject.GetComponent<Control>().Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Authorize"))
        {
            other.gameObject.GetComponent<Control>().Revert();
        }
    }
}
