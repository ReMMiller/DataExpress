using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Enums
	{
		enum eHeroes // : int (default data type for enum)
		{
			Aquaman,		// 0
			Spiderman,		// 1
			WonderWoman,	// 2
			Deadpool		// 3
		}

		enum eVillians : byte
		{
			DarthVader = 5,	// 5 
			TheJoker,		// 6
			Deadpool		// 7
		}

		enum eLocations : byte
		{
			Earth = 20,		// 20 
			Atlantis = 23,  // 23
			Gotham = 12     // 12
		}

		public static void Display()
		{
			eLocations location = eLocations.Earth;
			VisitLocation(location);
			Console.WriteLine("enum: {0} - {1}", eLocations.Atlantis, (byte)eLocations.Atlantis);

			eVillians villians = eVillians.DarthVader;
			PrintEnums(villians);

			DayOfWeek day = DayOfWeek.Monday;
			PrintEnums(day);

			ConsoleColor color = ConsoleColor.Gray;
			PrintEnums(color);
		}

		static void VisitLocation(eLocations location)
		{
			switch (location)
			{
				case eLocations.Earth:
					Console.WriteLine("Welcome to Earth.");
					break;
				case eLocations.Atlantis:
					Console.WriteLine("Under the sea.");
					break;
				case eLocations.Gotham:
					Console.WriteLine("Gotham is in trouble.");
					break;
				default:
					break;
			}
		}

		static void PrintEnums(System.Enum e)
		{
			Console.WriteLine("storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

			Array enumData = Enum.GetValues(e.GetType());
			for (int i = 0; i < enumData.Length; i++)
			{
				Console.WriteLine("{0} - {0:d}", enumData.GetValue(i));
			}
		}
	}
}
