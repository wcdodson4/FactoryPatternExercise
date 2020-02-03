using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Nokia : ICallable
    {
        public void Build()
        {
            Console.WriteLine("You have created a Nokia.");
        }
    }
}
