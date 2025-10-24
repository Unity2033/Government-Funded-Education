using UnityEngine;

public class Winchester : Weapon
{
    public override void Launch()
    {
        Instantiate(bullet, muzzlePosition.position, transform.rotation);
    }
}
