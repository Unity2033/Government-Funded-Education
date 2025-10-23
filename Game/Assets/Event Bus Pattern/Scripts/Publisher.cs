using UnityEngine;

public class Publisher : MonoBehaviour
{
    void Start()
    {
        EventManager.Publish(Condition.START); 
    }

    public void Pause()
    {
        EventManager.Publish(Condition.PAUSE);
    }
}
