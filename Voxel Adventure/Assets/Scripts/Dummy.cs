using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour {

    // move to a character controller when one is created.
    // This is for the Input system, where you will do Input.GetButtonDown("FireTrigger") and in the InputSystem, create something called FireTrigger, which will map to the button, but in code, it will be easier to read this way
    public string[] playerCtrlMap = { "Horizontal", "Vertical", "ChangeAbility", "UseAbility" }; // NEED TO SET IN INSPECTOR TOO

    private int spellNumber;
    [SerializeField] private int maxSpells;
    private bool changeAbility, useAbility;
    public List<SpellSO> spellSO;
    
	void Start () {
        maxSpells = spellSO.Count - 1; // as arrays start at 0, need to -1 so the array does not go out of range
	}
    
	void Update ()
    {
        ChangeSpell();
        UseSpell();
    }

    private void UseSpell()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetAxis(playerCtrlMap[3]) >= 0.5f)
        {
            if (useAbility == false)
            {
                useAbility = true;
                Debug.Log(spellSO[spellNumber].Description);
                Debug.Log(spellSO[spellNumber].Name);
                spellSO[spellNumber].Cast();
            }
        }
        else
            useAbility = false;
    }

    private void ChangeSpell()
    {
        if(Input.GetAxis(playerCtrlMap[2]) == 0)
            changeAbility = false;

        if (Input.GetKeyDown("q") || Input.GetAxis(playerCtrlMap[2]) >= 0.5 && changeAbility == false)
        {
            changeAbility = true;
            if (spellNumber > 0)
                spellNumber--;
            else
                spellNumber = maxSpells;
        }
        if (Input.GetKeyDown("e") || Input.GetAxis(playerCtrlMap[2]) <= -0.5 && changeAbility == false)
        {
            changeAbility = true;
            if (spellNumber < maxSpells)
                spellNumber++;
            else
                spellNumber = 0;
        }
    }
}