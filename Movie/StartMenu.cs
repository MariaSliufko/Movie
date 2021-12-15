using System;


namespace Movie
{
    public class StartMenu
    {

        public static void StartMenuChoice()
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
                    SearchByMovieIdP.SearchByIdP().Wait();
                    StartMenu.StartMenuChoice();
                    break;

                case 2:
                    SearchByMovieTitle.SearchByTitle().Wait();
                    StartMenu.StartMenuChoice();
                    break;

                case 3:
                    ExitProgram.EndMessage();
                    break;
            }



            }

        internal static void StartmenuChoice()
        {
            throw new NotImplementedException();
        }
    }

    }

