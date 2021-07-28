using System;
using LegoMinfigures.Heads;

namespace LegoMinfigures.Torsos
{
	abstract class TorsoBase
	{
		public bool HasShirt { get; set; }
		public LegoColor Color { get; set; }
		public string ToolBelt { get; set; }

		public virtual void Greeting()
		{
			Console.WriteLine("Give a high five.");
		}

		public abstract void Wiggle();
	}
}
