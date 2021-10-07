using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string userLastName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimel on {userFirstName.Length} sümbolit ja {userLastName} sümbolit.");
            if (userFirstName.Length < userLastName.Length)
            {
                Console.WriteLine($"Sinu eesnimel on {userFirstName.Length} sümbolit ja {userLastName} sümbolit.");
            }
        }
    }
}
