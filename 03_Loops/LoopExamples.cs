using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 15;
            //1 Starting point 
            //2 Condition that while true,keep the loop running
            //3 what happens agter each loop
            //4 Body of the loop, what happens each iteration
            //for ...//1....//2 .....//3
            for (int i=0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
        }
        [TestMethod]
        public void ForEachLoop()
        {
            string name = "Eleven Fifty Acadamy";
            //1 Collection that bing worked on 
            //2 Name of the current iteration bing used
            //3 Current Type in the Collection
            //4 in leyword, used to separate the individual and the collection
            //5 Body of the loop
            foreach (var letter in name)
            {
                Console.WriteLine(letter);
            }

        }
        [TestMethod]
        public void WhileLoops()
        {
            int total = 30;
            //1 Loop runs 
            //2 The body of the loop

            //while 

            while (total != 0)
            {
                Console.WriteLine(total);
                total--;
            }

        }
    }

}
