using System;
namespace Movie
{
    public class ExitProgram
    {

        
        public static void EndMessage(string text = "Thank you for using my movie search app!", int delay = 200)
        {
            Console.Clear();
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(delay);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Write(text.Substring(i + 1));
                        break;
                    }
                }
            }
        }


    }
}
