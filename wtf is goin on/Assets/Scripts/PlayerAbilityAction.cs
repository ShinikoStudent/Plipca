using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script is only the skeleton for the skillsets for each of the "personalities"
*/

public class PlayerAbilityAction : MonoBehaviour
{
    public PlayerMovement p;

    bool ability1Active;
    bool ability2Active;
    bool ability3Active;

    bool abilityAnyActive;

    private void Awake()
    {
        p = GetComponent<PlayerMovement>();
    }
    

    void ActiveAbilityUpdate()
    {
        if (ability1Active || ability2Active || ability3Active) abilityAnyActive = true;
        else abilityAnyActive = false;
    }

    public virtual void Ability1()
    {
        Debug.Log("ability1");
    }

    public virtual void Ability2()
    {
        Debug.Log("ability2");
    }

    public virtual void Ability3()
    {
        Debug.Log("ability3");
    }
}
