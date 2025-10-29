using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
