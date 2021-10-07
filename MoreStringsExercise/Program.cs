using System;

namespace MoreStringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            String racecar = "racecar";

            for (int i = racecar.Length - 1; i >= 0; i--)
            {
                Console.Write(racecar[i]);
            }
        }
    }
}
