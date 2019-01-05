using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityController : MonoBehaviour
{
    SpriteRenderer pSprite;
    int currentMode = 0;

    public List<PlayerModeSkeleton> abilityList;

    PlayerMovement pMovement;


    
    public KeyCode Ability1Button;
    public KeyCode Ability2Button;
    public KeyCode Ability3Button;
    public KeyCode modeSwitchLeft = KeyCode.Q;
    public KeyCode modeSwitchRight = KeyCode.E;

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
        if (Input.GetKeyDown(Ability1Button))
            abilityList[currentMode].Ability1OnPress();
        else if (Input.GetKeyUp(Ability1Button))
            abilityList[currentMode].Ability1OnRelease();
    }
}
