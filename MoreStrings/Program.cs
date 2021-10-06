using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lõpevad punktiga
            //--> Harry Potter --> H. P.
            Console.WriteLine("Sisesta eesnimi.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi.");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Tere, {firstName[0]}. {lastName[0]}.");
        }
    }
}
