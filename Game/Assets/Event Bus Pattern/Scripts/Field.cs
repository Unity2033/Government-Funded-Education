using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void OnEnable()
    {
        EventManager.Subscribe(Condition.START, Execute);
        EventManager.Subscribe(Condition.PAUSE, Pause);
        EventManager.Subscribe(Condition.EXIT, Destroy);
    }

    public void Execute()
    {
        animator.enabled = true;
    }

    public void Pause() 
    {
        animator.enabled = false; 
    }

    public void Destroy() 
    {
        Destroy(gameObject);
    }

    private void OnDisable()
    {
        EventManager.Unsubscribe(Condition.START, Execute);
        EventManager.Unsubscribe(Condition.PAUSE, Pause);
        EventManager.Unsubscribe(Condition.EXIT, Destroy);
    }

}
