using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : PlayerModeSkeleton
{
    public GameObject bullet;
    public Transform ShootPoint;

    public override void Ability1OnPress()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        Instantiate(bullet, ShootPoint.position, ShootPoint.rotation);
    }
}
