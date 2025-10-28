using UnityEngine;

public class Walk : State
{
    public override void Enter(Character character) { }

    public override void Update(Character character)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.SetState(new PickUp());
        }

        if (Mathf.Abs((int)Input.GetAxisRaw("Horizontal")) == 0)
        {
            character.SetState(new Idle());
        }

        int x = (int)Input.GetAxisRaw("Horizontal");

        character.animator.SetInteger("X", x);
    }

    public override void Exit(Character character)
    {
        character.animator.SetInteger("X", 0);
    }
}
