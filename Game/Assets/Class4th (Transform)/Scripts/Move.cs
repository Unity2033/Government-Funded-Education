using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;

    public void OnMove(Vector3 vector3)
    {
        direction = vector3;

        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
