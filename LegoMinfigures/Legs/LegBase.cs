﻿using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LegoMinfigures.Legs
{
	abstract class LegBase
	{
		public Bottoms Bottoms { get; set; }
		public Shoes Kicks { get; set; }

		public virtual void Dance()
		{
			Console.WriteLine("Start doing the Electric Slide.");
		}

		public abstract void Walk();

	}
}
