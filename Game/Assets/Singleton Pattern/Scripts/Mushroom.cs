using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField] float speed = 50;

    void Update()
    {
        if (GameManager.Instance.State == false) return;

        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
