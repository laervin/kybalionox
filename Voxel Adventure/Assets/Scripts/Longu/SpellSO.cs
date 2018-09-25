using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "Character/Spells", order = 1)]
[System.Serializable]

public class SpellSO : ScriptableObject {

    public Spell spell;
    public float cooldownTime;

    public void Cast()
    {
        Debug.Log("You have just cast: " + spell);
    }

    public string Name
    {
        get { return "" + spell; }
    }

    public string Description
    {
        get { return "This is " + spell + " principle"; }
    }

}
