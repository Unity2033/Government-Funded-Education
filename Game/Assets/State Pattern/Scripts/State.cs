using UnityEngine;

public abstract class State
{
    public abstract void Enter(Character character);
    public abstract void Update(Character character);
    public abstract void Exit(Character character);
}
