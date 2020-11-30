using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class Program
    {
        static void Main(string[] args)//acts as our progrma's  .exe file,aka excutable. This is the file we double click om to start any program
        {

            Console.WriteLine("Welcome to your Tool Box!");
            Console.WriteLine("You can either hot \"Y\"then Enter to continue,or hit\"N\" then ENTER    TO CLEAR cONSOLE AND cONTINUE.");

            string userResponse = Console.ReadLine();

            if (userResponse.ToUpper() == "Y")
            {
                KeyToContinue();
            }
            else if (userResponse.ToUpper() == "N")
            {
                KeyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure friend, but I'm gone close");
                Console.ReadLine();
            }


            //KeyToContinue();
            //clearConsole();
            //Console.ReadLine();



            void KeyToContinue()
            {
            Console.WriteLine("Press Enter To Exit");
            Console.ReadLine();
            }

            void clearConsole()
            {
            Console.Clear();
            Console.WriteLine("The console is clear now.");

            }

            void KeyToContinueWithClearConsole()
            {
                KeyToContinue();
                clearConsole();
            }
        }
    }
}
