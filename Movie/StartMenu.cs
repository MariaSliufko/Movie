using System;
namespace Movie
{
    public class StartMenu
    {
        
        public StartMenu()
        {
            int userInput = 0;
            do
            {
                Console.WriteLine(@"Welcome! Choose a number to continue.
1. Search movie by id.
2 Search movie by title.
3. Exit.");
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }

            }

            while (userInput == 0 || userInput > 4);

            switch (userInput)
            {
                case 1:
                    //söka med id
                    break;

                case 2:
                    //Söka med titel
                    break;

                case 3:
                    //exit
                    break;
            }



            }
        }

    }

