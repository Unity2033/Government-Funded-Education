using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] List<Weapon> weapons;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }
        
    }

    void Attack()
    {
        weapons[count].Launch();
    }

    void Swap()
    {
        weapons[count].gameObject.SetActive(false);

        count = (count + 1) % weapons.Count;

        weapons[count].gameObject.SetActive(true);
    }
}
