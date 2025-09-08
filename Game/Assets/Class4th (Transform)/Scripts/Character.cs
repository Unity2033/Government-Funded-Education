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

        // 벡터의 크기를 1로 설정합니다.
        direction.Normalize();

        // Time.deltaTime 
        // 마지막 프레임 이후의 완료되는 시간
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
