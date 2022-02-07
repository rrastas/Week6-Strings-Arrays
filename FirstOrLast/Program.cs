using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust 
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta enda eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");
            Console.WriteLine();
            
            Console.WriteLine("Sisesta enda perekonna nimi:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Sinu perekonnanimes on {lastName.Length} sümbolit.");
            Console.WriteLine();

            if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("Perekonnanimes on rohkem sümboleid.");
                Console.WriteLine();
            }

            else if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("Eesnimes on rohkem sümboleid.");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Nii eesnimes kui ka perekonnanimes on sama palju sümboleid.");
            }
        }
    }
}
