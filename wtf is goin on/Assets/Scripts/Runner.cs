using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : PlayerModeSkeleton
{
    public float sprintSpeed = 90;

    public override void Ability1OnPress()
    {
        p.currentMaxRunSpeed = sprintSpeed;
    }

    public override void Ability1OnRelease()
    {
        p.currentMaxRunSpeed = p.defaultRunSpeed;
    }
}
