﻿using System;

namespace LegoMinfigures.Torsos
{
	class BatSuitTorso : TorsoBase
	{
		public bool HasBatBoomerang { get; set; }

		public override void Greeting()
		{
			base.Greeting();
			Console.WriteLine("Gives fist pump.");
		}

		public override void Wiggle()
		{
			Console.WriteLine("Flex on em!");
		}

		public void Donates()
		{
			Console.WriteLine("Donates $150 million to the Children Are The Future Charity");
		}

	}
}
