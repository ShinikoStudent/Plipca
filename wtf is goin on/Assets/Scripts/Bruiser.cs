using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruiser : PlayerModeSkeleton
{
    public GameObject PunchHitBox;
    public Transform ShootPoint;

    public override void Ability1OnPress()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            Instantiate(PunchHitBox, ShootPoint.position, ShootPoint.rotation);
    }
}
