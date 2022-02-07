﻿using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kuvab, mitu 'a' tähte on kasutaja ees- ja perekonnanimes kokku

            Console.WriteLine("Sisesta enda eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta enda perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();
            Console.WriteLine(fullName);

            int aCounter = 0;


            for(int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }

            else
            {
                Console.WriteLine($"Sinu eesnimes on {aCounter} 'a' täht.");
            }

        }
    }
}
