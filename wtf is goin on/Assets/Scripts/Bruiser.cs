using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruiser : PlayerAbilityAction
{
    public GameObject PunchHitBox;
    public Transform ShootPoint;

    public override void Ability1()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            Instantiate(PunchHitBox, ShootPoint.position, ShootPoint.rotation);
    }
}
