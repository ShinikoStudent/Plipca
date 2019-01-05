using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : PlayerAbilityAction
{
    public GameObject bullet;
    public Transform ShootPoint;

    public override void Ability1()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        Instantiate(bullet, ShootPoint.position, ShootPoint.rotation);
    }
}
