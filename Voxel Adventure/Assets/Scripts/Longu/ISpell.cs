public interface ISpell
{
	//This file constains an Interface
	//Interfaces ensure every class and/or struct, that implements them, has to have properties and functions specified here (doesn't work for fields)
	//You can not make instance of a interface (aka new ISpell();) but you can make a field of type ISpell (ISpell Spell = new ExampleSpell();)
	//For example I added a 'Cast' function, that ensures every spell will have some logic when you cast a spell
	//I also added 2 properties, 'Name' and 'Description', which are not necessary for ability system you need but I though that they may come useful. If not, just delete them from this file.


	//Obviously the functions can be other than void and can have arguments
	void Cast();
	string Name { get; }
	string Description { get; }
}