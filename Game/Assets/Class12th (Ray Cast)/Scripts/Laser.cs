using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] float attack;
    [SerializeField] LayerMask layerMask;
    [SerializeField] RaycastHit rayCastHit;
    [SerializeField] float maxDistance = 100.0f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red);

            if(Physics.Raycast(ray, out rayCastHit, maxDistance, layerMask))
            {
                rayCastHit.collider.GetComponent<HealthBar>().Damage(attack);
            }
        }
    }
}
