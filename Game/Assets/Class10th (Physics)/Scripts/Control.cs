using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float power;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * power, ForceMode.Force);
    }
}
