using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] float targetY;

    void Update()
    {
        if (GameManager.Instance.State == false) return; 

        float y = Mathf.PingPong(Time.time, targetY) - 1;

        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
