﻿using LegoMinfigures.Heads;
using LegoMinfigures.Legs;
using LegoMinfigures.Minifigures;
using LegoMinfigures.Torsos;
using System;
using System.Collections.Generic;

namespace LegoMinfigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();

            workerHead.Color = LegoColor.Yellow;
            
            var batmanHead = new BatmanHead();

            var astronautHead = new AstronautHead();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };

            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }

            var batmanTorso = new BatSuitTorso();
            batmanTorso.Color = LegoColor.Green;
            batmanTorso.HasBatBoomerang = true;
            batmanTorso.HasShirt = false;
            batmanTorso.Donates();

            var cowboyTorso = new CowboyTorso();

            var sumoTorso = new SumoTorso();

            var torsos = new List<TorsoBase>() { batmanTorso, cowboyTorso, sumoTorso };

            foreach(var torso in torsos)
			{
                torso.Greeting();
                torso.Wiggle();
			}


            var seaLeg = new SeaLeg();
            seaLeg.AreWobbly = true;
            seaLeg.Bottoms = Bottoms.Chaps;
            seaLeg.NumberOfLegs = 3;
            seaLeg.Kicks = Shoes.ShelltoeAdidas;


            var magicLeg = new MagicLeg();
            magicLeg.Bottoms = Bottoms.Chaps; //this is a magical moment
            magicLeg.HasInvisibleLegs = true;
            magicLeg.MeasuringLegs("small");
            Console.WriteLine($"Magic legs have a length of {magicLeg.Length} inches.");

            var legs = new List<LegBase>() { seaLeg, magicLeg };

            foreach(var leg in legs)
			{
                leg.Dance();
                leg.Walk();
			}

            Console.WriteLine("Before Bob.");


            //var bob = new Minifigure(workerHead, cowboyTorso, new SeaLeg());
            var bob = new Minifigure(workerHead, cowboyTorso, seaLeg);
            bob.BuildIt();
            

            Console.WriteLine("You just saw Bob do his thang!");
            Console.ReadLine();

        }
    }
}
