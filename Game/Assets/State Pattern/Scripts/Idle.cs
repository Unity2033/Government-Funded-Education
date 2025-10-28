using UnityEngine;

public class Idle : State
{
    public override void Enter(Character character)
    {
        character.animator.SetInteger("X", 0);
    }

    public override void Update(Character character)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.SetState(new PickUp());
        }

        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0)
        {
            character.SetState(new Walk());
        }
    }

    public override void Exit(Character character)
    {
    
    }

}
