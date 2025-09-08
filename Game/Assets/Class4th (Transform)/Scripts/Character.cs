using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 10.0f;

    void Start()
    {
     
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // ������ ũ�⸦ 1�� �����մϴ�.
        direction.Normalize();

        // Time.deltaTime 
        // ������ ������ ������ �Ϸ�Ǵ� �ð�
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
