using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityController : MonoBehaviour
{
    SpriteRenderer pSprite;
    int currentMode = 0;

    /*  Mode 1: Runner
     *  Mode 2: Gunner
     *  Mode 3: Bruiser
     */

    public List<PlayerModeSkeleton> abilityList;

    PlayerMovement pMovement;

    public KeyCode Ability1Button;
    public KeyCode Ability2Button;
    public KeyCode Ability3Button;
    public KeyCode modeSwitchLeft = KeyCode.Q;
    public KeyCode modeSwitchRight = KeyCode.E;

    bool ability1Active;
    bool ability2Active;
    bool ability3Active;


    // Start is called before the first frame update
    void Awake()
    {
        pSprite = GetComponent<SpriteRenderer>();
        pMovement = GetComponent<PlayerMovement>();

        abilityList.Add(GetComponent<Runner>());
        abilityList.Add(GetComponent<Gunner>());
        abilityList.Add(GetComponent<Bruiser>());
    }
    
    // Update is called once per frame
    void Update()
    {
        modeChange();
        modeVisualUpdate();
        AbilityButtonCheck();
    }

    void modeChange()
    {
        if(!IsAbilityActive())
        if (Input.GetKeyDown(modeSwitchLeft))
        {
            currentMode--;
            if (currentMode == -1) currentMode = 2;
            switchReset();
        }
        else if (Input.GetKeyDown(modeSwitchRight))
        {
            currentMode++;
            if (currentMode == 3) currentMode = 0;
            switchReset();
        }
    }

    void modeVisualUpdate()
    {
        if (currentMode == 0) pSprite.color = Color.white;
        else if (currentMode == 1) pSprite.color = Color.black;
        else if (currentMode == 2) pSprite.color = Color.red;      
    }

    void switchReset()
    {
        pMovement.currentMaxRunSpeed = pMovement.defaultRunSpeed;
    }

    void AbilityButtonCheck()
    {
        if (!IsAbilityActive() || ability1Active)
        {
            if (Input.GetKeyDown(Ability1Button))
            {
                abilityList[currentMode].Ability1OnPress();
                ability1Active = true;
            }
            else if (Input.GetKeyUp(Ability1Button))
            {
                abilityList[currentMode].Ability1OnRelease();
                ability1Active = false;
            }
        }

        if (!IsAbilityActive() || ability2Active)
        {
            if (Input.GetKeyDown(Ability2Button))
            {
                abilityList[currentMode].Ability2OnPress();
                ability2Active = true;
            }
            else if (Input.GetKeyUp(Ability2Button))
            {
                abilityList[currentMode].Ability2OnRelease();
                ability2Active = false;
            }
        }
    }

    bool IsAbilityActive()
    {
        if (ability1Active || ability2Active || ability3Active) return true;
        else return false;
    }
}
