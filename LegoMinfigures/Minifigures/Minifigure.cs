using System;
using LegoMinfigures.Heads;
using LegoMinfigures.Legs;
using LegoMinfigures.Torsos;

namespace LegoMinfigures.Minifigures
{
	class Minifigure
	{
		HeadBase Head { get; }
		TorsoBase Torso { get; }
		LegBase Leg { get; }


		public Minifigure(HeadBase head, TorsoBase torso, LegBase leg)
		{
			Head = head;
			Torso = torso;
			Leg = leg;
		}

		public void BuildIt()
		{
			Console.WriteLine("I love to build things with my bare hands.");
			Head.SayHi();
			Head.Spin();
		}


	}
}
