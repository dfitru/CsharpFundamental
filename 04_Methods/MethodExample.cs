using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExample
    {
        //Input
        //What we do
        //Output
        public int AddTwoNumbers(int num1,int num2) 
        {
            int sum = num1 + num2;
            return sum;
        }


        [TestMethod]

        // public access modifier 
        // void return tyoe
        //method signenature(Name and list of paramerters)

        private int SubstractNum(int x, int y)
        {
            int Sub1 = SubstractNum(50, 30);
            return Sub1;
        }

        private int Multiply (int a, int b)
        {
            int mul = Multiply(5, 25);
            return mul;
        }
        public void MethodTests()
        {
          int sum1=  AddTwoNumbers(7, 12);
            int sum2 = AddTwoNumbers(10, 20);
        }
    }
}
