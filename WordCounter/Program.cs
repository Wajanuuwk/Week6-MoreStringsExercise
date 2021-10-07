using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloW = "Hello World!";
            int wordCounter = 1;
            
            for(int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == ' ')
                {
                    wordCounter++;
                }

            }
            Console.Write($"Lauses on {helloW} on {wordCounter} sõna");
        }
    }
}
