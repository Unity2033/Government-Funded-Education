using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float power;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] ForceMode forceMode;

    private void Awake()
    {
        forceMode = ForceMode.Force;
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
        rigidbody.AddForce(direction * power, forceMode);
    }

    public void Soar()
    {
        power = 0.5f;
        direction = Vector3.up;
        forceMode = ForceMode.Impulse;
    }

    public void Revert()
    {
        power = 5f;
        direction = Vector3.zero;
        forceMode = ForceMode.Force;
    }
}
