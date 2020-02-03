using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Apple : ICallable
    {
        public void Build()
        {
            Console.WriteLine("You have created an iPhone.");
        }
    }
}
