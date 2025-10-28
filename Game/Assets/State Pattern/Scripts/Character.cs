using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] State currentState;
    
    public Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        currentState = new Idle();
    }

    void Update()
    {
        currentState.Update(this); 
    }

    public void SetState(State state)
    {
        currentState.Exit(this);

        this.currentState = state;

        currentState.Enter(this);
    }

}
