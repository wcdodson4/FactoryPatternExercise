using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Motorola : ICallable
    {
        public void Build()
        {
            Console.WriteLine("You have created a Motorola.");
        }
    }
}
