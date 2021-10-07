using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "Hello World!" pikkust Lenght omaduse kasutamata
            
            string helloworld = "hello World!";
            int counter = 0;
            foreach (char character in helloworld)
            {
                counter = counter + 1;

            }

            Console.WriteLine($"{helloworld} on {counter} sümbolit pikk.");
        }
    }
}
