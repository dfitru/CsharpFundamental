using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--Whole numbers

            //byte oneBytesWorth;
            //oneBytesWorth = 255;
            //short smallWholeNumber = 16;         //Int16
            //Int16 anotherSmallNumber = 16;       //
            //int wholeNumber = 32;
            //long largeNumber = 64;



            //// -----Decimal 
            //float floatExample = 1.34f;
            //double doubleExample = 1.2789;
            //decimal decimalExample=1.7m;


            //char letter = 'a';


            //--Operaters

            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            int diff = numOne - numTwo;
            int pro = numOne * numTwo;
            int quot = numOne / numTwo;
            int reminder = numOne % numTwo;


            Console.WriteLine("Hello");
             
        }
        [TestMethod]
        public void ReferenceTypes()
        {
            //---Strings
            string StringExample = "This is my laptop.";
            string name = "David";


            //formatting 
            string concatenate =StringExample+" "+ 90;
            string concatenate2 = StringExample+' ' + name;
            string interpolate = $"{name}.Here is my name: {StringExample}.";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);


            //---other Ojejct Examples

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomeDate = new DateTime(1983, 05, 20);

            TimeSpan eaittime = randomeDate - now;


            //--Collections

            //--Arrys
            string anotherExampleString = "Today is Thursday";
            string[] stringArry = {anotherExampleString,"Hellow","World","!" }; 



            //--Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            //Queues
            Queue<string> FirstInFirstOut = new Queue<string>();

            //Dictionary

            Dictionary<char, string> KeyValuePair = new Dictionary<char, string>();

            //other collections

            SortedList<int, string> sortedKeyvaluePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();



        }
    }
}
