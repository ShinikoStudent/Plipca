using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : PlayerAbilityAction
{
    public float sprintSpeed = 90;

    public override void Ability1()
    {
        
        /*
     if(!abilityAnyActive || ability1Active)
     {*/
        if (Input.GetKey(KeyCode.LeftShift))
        {

            p.currentMaxRunSpeed = sprintSpeed;
            //ability1Active = true;
        }
        else
        {
            p.currentMaxRunSpeed = p.defaultRunSpeed;
            //ability1Active = false;
        }/*
        }*/
    }
}
