using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Condionals
{
    [TestClass]
    public class ConditionalsExample
    {
        [TestMethod]
        public void Booleans()
        {
            //booleans are a True/False Values
            bool isTrue = 17 > 5;
            bool isFalse = 12 == 4;
        }

        [TestMethod]
        public void IfElseStament()
        {
            int age = 14;
            if (age > 17)
            {
                Console.WriteLine("You are an Adult.");
            }
            else if (age > 6 && age<17)
            {
                Console.WriteLine("You are a kid.");
            }
            else Console.WriteLine("You are a baby");
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)
            {
                case 16:
                    //The Code for the 18
                    break;
                case 18:
                    break;
                case 20:
                case 22:
                case 24:
                    break;
                default:
                    Console.WriteLine("You are not btween 16-24");
                    break;
            }

        }
        [TestMethod]
        public void Ternaryies()
        {
            int age = 37;
            // variable=(boolean statement) ? ValueTrue:ValueFalse;

            bool isAge = (age == 200) ? true : false;

        }
    }
}
