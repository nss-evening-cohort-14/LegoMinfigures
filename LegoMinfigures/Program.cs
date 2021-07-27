using LegoMinfigures.Heads;
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


        }
    }
}
