//This class contains all the logic for your spell book.
//You don't have to keep it here, I recomend to add this class to some other class for spellbook if you have one
//This class can bo a monobehaviour if you need it, but for now there is no reason

public static class SpellBook
{
	public static ISpell[] Spells = new ISpell[7];

	private static int ChosenSpell = 0;

	/// <summary>
	/// Use this to 'unlock' a spell.
	/// For example : AddSpell(new ExampleSpell(),2);
	/// </summary>
	/// <param name="Spell">The spell you're unlocking.</param>
	/// <param name="Index">Index of the spell, from 0 to 6</param>
	public static void AddSpell(ISpell Spell, int Index)
	{
		Spells[Index] = Spell;
	}

	/// <summary>
	/// Use this function to choose a spell to cast
	/// </summary>
	/// <param name="Index"> Index of the spell, from 0 to 6</param>
	public static void ChooseSpell(int Index)
	{
		if (Spells[Index] == null)
			return; // You may want to display some message here or somethin
		ChosenSpell = Index;
	}

	/// <summary>
	/// Use this function to cast spells
	/// </summary>
	public static void CastSpell()
	{
		Spells[ChosenSpell].Cast();
	}
}