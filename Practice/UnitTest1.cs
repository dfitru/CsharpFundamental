using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Practice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public double Quotient(int a,int b)
        {
            int c;
            double d;
            c = a / b;
            d = Convert.ToDouble(c);

            return d;
        }
        [TestMethod]
      
        public string GreetingName(string name)
        {
            return  $"greeting, :{name}";

        }
        [TestMethod]
        public int MaxVal(int x,int y)
        {

            if (x > y)
            {
                return x;
            }
            else return y;
        }
        [TestMethod]

        public int FromString(string number)
        {
            int x = int.Parse(number);
            return x;

        }

        [TestMethod]
        public DateTime FindBirthday(int Year)
        {
            DateTime Now = new DateTime(Year,5,6);

            return Now ;

        }

        [TestMethod]
        public void Output()
        {
            DateTime x=FindBirthday(1991);
            Console.WriteLine(x);
        }
        public string FizBuz(int[] x )
            
        { int i;
            foreach ( i in x)
            {
                if (i%3==0)
                { 
                    return i.ToString="Fizz";
                }
                else if(i%5==0)
                {
                    return "Buzz";
                }
                else if (i%3==0 && i%5==0)
                {
                    return "FizzBizz"
                }
                
            }
            retrun i;
              
        }
        
    }
}
