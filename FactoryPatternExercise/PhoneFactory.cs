using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class PhoneFactory
    {
        public static ICallable GetPhone(string phoneType)
        {
            switch (phoneType.ToLower())
            {
                case "nokia":
                    return new Nokia();
                case "motorola":
                    return new Motorola();
                case "apple":
                    return new Apple();
                default:
                    return new Apple();
            }
        }
    }
}
