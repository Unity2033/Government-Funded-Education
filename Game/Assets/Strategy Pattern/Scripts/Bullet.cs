using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float destroyTime;

    void Start()
    {
        Destroy(gameObject, destroyTime);   
    }

    void Update()
    {
       transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
