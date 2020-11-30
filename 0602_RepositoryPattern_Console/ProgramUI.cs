using _0602_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;

namespace _0602_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contetRepo = new StreamingContentRepository();
        public void Run()
        {
            SeedContentList();
            Menu();
        }
        //Menu
        private void Menu()
        {
            bool keepRuning = true;
            while (keepRuning)
            {

                //Dispalay our option to the user

                Console.WriteLine("Select a menu option:\n" +
                    "1. Create new Content:\n" +
                    "2. Viw all content:\n" +
                    "3. Vew Contetn By Title\n" +
                    "4. Update Existing option:\n" +
                    "5. Delete Existing Content\n" +
                    "6.Exit");

                //Gret the user input
                string input = Console.ReadLine();
                //Evaluate the user input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new Content
                        CreateNewContent();
                        break;
                    case "2":
                        //View all content
                        DispalyAllContetn();
                        break;
                    case "3":
                        //View contetn by Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update Existing Contetnt
                        UpdateExistingContetn();
                        break;
                    case "5":
                        //Delte Existing contetn
                        DeleteExistingContetn();

                        break;
                    case "6":
                        //Existing
                        Console.WriteLine("Goodbye!");
                        keepRuning = false;
                        break;


                    default:
                        Console.WriteLine("Please Enter a Valid Number.");
                        break;
                }
                Console.WriteLine("Press any Key to Continue.....");
                Console.ReadKey();
                Console.Clear();
            }
        }
        // Create new StreamingContent
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            // Title
            Console.WriteLine("Enter the Titlte for the content:");
            newContent.Title = Console.ReadLine();
            //Description 
            Console.WriteLine("Enter the description for the contetn:");
            newContent.Description = Console.ReadLine();
            //Maturity Rating
            Console.WriteLine("Enter rating for contetn (G,PG,)");
            newContent.MaturityRating = Console.ReadLine();

            //StarRating
            Console.WriteLine("Eneter Star Count for the content:");
            string starAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starAsString);
            //IsFamilyFriendly?
            Console.WriteLine("Is this content family Friendly:(y/n");
            string familyFriendlyString = Console.ReadLine().ToLower();
            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;

            }
            else newContent.IsFamilyFriendly = false;
            //Gener Type

            Console.WriteLine("Eneter the Gere Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5.Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string generAsString = Console.ReadLine();
            int generAsInt = int.Parse(generAsString);
            newContent.TypeOfGener = (GenerType)generAsInt;

            _contetRepo.AddContentList(newContent);
        }
        //Vew Current StreamingContetn contetn that is Saved 

        private void DispalyAllContetn()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _contetRepo.GetContetList();

            foreach (StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title:{content.Title}\n" +
                    $"Desc:{content.Description}");
            }

        }
        //View Existing Content by tile

        private void DisplayContentByTitle()
        {
            Console.Clear();
            //Prompt the user to give me a title
            Console.WriteLine("Enter Title.");
            //get the users input
            string title = Console.ReadLine();

            //Find that Title
            StreamingContent content = _contetRepo.GetContentByTitle(title);

            //Dispay Said Cinten if it isn't null
            if (content!=null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description:{content.Description}\n" +
                    $"Maturity Rating:{content.MaturityRating}\n" +
                    $"Stars:{content.StarRating}\n" +
                    $"Is it Family Friendly?{content.IsFamilyFriendly}\n" +
                    $"Gener{content.TypeOfGener}" );

            }
            else
            {
                Console.WriteLine("Not Content by that Title.");
            }

        }

        //Update Existing Contet
        private void UpdateExistingContetn()
        {
            //Display all content
            DispalyAllContetn();
            //Ask For the title of the content to update
            Console.WriteLine("Which Title do you want to updyae?");



            //Get that title
            string oldTitle = Console.ReadLine();

            //We will build a new object
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            // Title
            Console.WriteLine("Enter the Titlte for the content:");
            newContent.Title = Console.ReadLine();
            //Description 
            Console.WriteLine("Enter the description for the contetn:");
            newContent.Description = Console.ReadLine();
            //Maturity Rating
            Console.WriteLine("Enter rating for contetn (G,PG,)");
            newContent.MaturityRating = Console.ReadLine();

            //StarRating
            Console.WriteLine("Eneter Star Count for the content:");
            string starAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starAsString);
            //IsFamilyFriendly?
            Console.WriteLine("Is this content family Friendly:(y/n");
            string familyFriendlyString = Console.ReadLine().ToLower();
            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;

            }
            else newContent.IsFamilyFriendly = false;
            //Gener Type

            Console.WriteLine("Eneter the Gere Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5.Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string generAsString = Console.ReadLine();
            int generAsInt = int.Parse(generAsString);
            newContent.TypeOfGener = (GenerType)generAsInt;

           bool wasUpdated= _contetRepo.UpdateExistingContent (oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("Congradulation! Your content Updated Succesfully.");
            }
            else
            {
                Console.WriteLine("Can not update Content.");
            }

        }
        //Delete Existing Contetn
        private void DeleteExistingContetn()
        {
            
            DisplayContentByTitle();
            //Get the Title they want to delete
            Console.WriteLine("\nEneter the Title you wnat to remove.");
            string input = Console.ReadLine();

            //Call the delete method
           bool wasDeleted =_contetRepo.RemoveContentFromList(input);

            //If the contetn was deleted , say so
            if (wasDeleted)
            {
                Console.WriteLine("The Contetn Sucessfully Deleted.");
            }
            else
            {
                Console.WriteLine("The content Could  not be Delted.");
            }
            //other wise stat if it couldnot be delted

        }

        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado","Tornados,but with sharks.","TV-14", 3.3, true, GenerType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Banker's life gets turned updidedown.", "R", 3.7, false, GenerType.Drama);

            _contetRepo.AddContentList(sharknado);
            _contetRepo.AddContentList(theRoom);
        }

    }
}
