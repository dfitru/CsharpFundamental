using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository_Console
{
    class ProgramUI
    {
        // method that runs/start the application
        public void Run()
        {
            Menu();
        }
        //Menupr
        private void Menu()
        {
            //Display our options to the user
            Console.WriteLine("Select A menu Option:\n" 
                +"1. Create New Content\n" +"2. View All Contemt\n"
                +"3. Viewcontent By Title\n"+"4. UpdateExisting Content\n"
                +"5. Delete Existing Content\n"+"6. Exist");
            // Get the users's input
            string input=Console.ReadLine();
            //Evaluate the users's  input and act  Accordingly
            switch (input)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Please enter a Valid number.");
                    break;
            }
        }
    }
}
