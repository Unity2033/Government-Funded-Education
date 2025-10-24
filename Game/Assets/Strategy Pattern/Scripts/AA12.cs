using UnityEngine;

public class AA12 : Weapon
{
    public override void Launch()
    {
        Instantiate(bullet, muzzlePosition.position, transform.rotation);
    }
}
