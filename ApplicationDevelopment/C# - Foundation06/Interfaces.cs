using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Interfaces
	{
		public static void Display()
		{
			// (1) interfaces
			Character mage = new Character();
			mage.Attack();
		}
	}

	/// <summary>
	/// An interface contains only the signatures of methods, properties, events or indexers. 
	/// A class or struct that implements the interface must implement the members of the interface 
	/// that are specified in the interface definition.
	public interface IMagic
	{
		float Power { get; set; }

		void CastSpell();
	}

	public interface IHealth
	{
		void Damage();
	}

	public class Character : IMagic, IHealth
	{
		public float Power { get; set; }

		public void CastSpell()
		{
			Console.WriteLine("Spell Cast");
		}

		public void Damage()
		{
			Console.WriteLine("Damage");
		}

		public void Attack()
		{
			if (this is IMagic)
			{
				Console.WriteLine("Is a magician.");
				CastSpell();
			}
		}
	}
}
