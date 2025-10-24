using UnityEngine;

public class BenelliM4 : Weapon
{
    public override void Launch()
    {
        Instantiate(bullet, muzzlePosition.position, transform.rotation);

    }
}
