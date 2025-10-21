using UnityEngine;

public class Golem : MonoBehaviour
{
    [SerializeField] float maximumSize = 1.0f;

    void Update()
    {
        if (GameManager.Instance.State == false) return;

        float offset = Mathf.PingPong(Time.time, maximumSize); 

        transform.localScale = new Vector3(offset, offset, offset);
    }
}
