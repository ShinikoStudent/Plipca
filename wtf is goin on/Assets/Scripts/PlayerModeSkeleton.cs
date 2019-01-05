using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script is only the skeleton for the skillsets for each of the "personalities"
*/

public class PlayerModeSkeleton : MonoBehaviour
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

    public virtual void Ability1OnPress()
    {
        Debug.Log("1 On Press");
    }
    public virtual void Ability1OnRelease()
    {
        Debug.Log("1 On Release");
    }

    public virtual void Ability2OnPress()
    {
        Debug.Log("2 On Press");
    }
    public virtual void Ability2OnRelease()
    {
        Debug.Log("2 On Release");
    }

    public virtual void Ability3OnPress()
    {
        Debug.Log("3 On Press");
    }
    public virtual void Ability3OnRelease()
    {
        Debug.Log("3 On Release");
    }
}
