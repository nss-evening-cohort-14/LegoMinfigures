using System;
using LegoMinfigures.Heads;

namespace LegoMinfigures.Torsos
{
	class SumoTorso : TorsoBase
	{
		public bool AreTheyThicc { get; set; }
		public LegoColor Fundoshi { get; set; }


		public override void Wiggle()
		{
			Console.WriteLine("Sumo, does their Shiko before the fight.");
		}

		public void FightPrep()
		{
			Console.WriteLine("Before the fight, pour down some salt.");
		}
	}
}
