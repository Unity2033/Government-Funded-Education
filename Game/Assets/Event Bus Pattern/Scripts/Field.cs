using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void OnEnable()
    {
        EventManager.Subscribe(Condition.START, EnableAnimator);
        EventManager.Subscribe(Condition.PAUSE, DisableAnimator);
    }

    public void EnableAnimator()
    {
        animator.enabled = true;
    }

    public void DisableAnimator() 
    {
        animator.enabled = false; 
    }

    private void OnDisable()
    {
        EventManager.Unsubscribe(Condition.START, EnableAnimator);
        EventManager.Unsubscribe(Condition.PAUSE, DisableAnimator);
    }

}
