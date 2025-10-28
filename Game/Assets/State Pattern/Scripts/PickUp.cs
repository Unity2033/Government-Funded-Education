using UnityEngine;

public class PickUp : State
{
    public override void Enter(Character character)
    {
        character.animator.SetTrigger("Pick Up");
    }

    public override void Update(Character character)
    {
        AnimatorStateInfo animatorStateInfo = character.animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Pick Up") && animatorStateInfo.normalizedTime < 1.0f || character.animator.IsInTransition(0))
        {
            character.SetState(new Idle());
        }
    }

    public override void Exit(Character character)
    {
      
    }

}
