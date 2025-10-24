using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected Transform muzzlePosition;

    public abstract void Launch();
}
