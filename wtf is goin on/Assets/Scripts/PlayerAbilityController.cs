using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityController : MonoBehaviour
{
    SpriteRenderer pSprite;
    int currentMode = 0;

    public List<PlayerAbilityAction> abilityList;

    PlayerMovement pMovement;

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
        abilityList[currentMode].Ability1();
    }

    void modeChange()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentMode--;
            if (currentMode == -1) currentMode = 2;
            switchReset();
        }
        else if (Input.GetKeyDown(KeyCode.E))
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
}
