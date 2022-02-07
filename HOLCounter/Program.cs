using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o', 'l' tähte on lauses "Hello World!"

            string fullSentence = "Hello, World!".ToLower();

           /* Console.WriteLine("Sisesta lause:");        
              string fullSentence = Console.ReadLine().ToLower(); */

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < fullSentence.Length; i++)
            {
                if (fullSentence[i] == 'h')
                {
                    hCounter++;
                }

                else if (fullSentence[i] == 'o')
                {
                    oCounter++;
                }

                else if (fullSentence[i] == 'l')
                {
                    lCounter++;
                }
            }

            if (hCounter != 1 && oCounter != 1 && lCounter != 1)
            {
                Console.WriteLine($"Lauses on {hCounter} 'h', {oCounter} 'o' ja {lCounter} 'l' tähte.");
            }

            else
            {
                Console.WriteLine($"Lauses on {hCounter} 'h', {oCounter} 'o' ja {lCounter} 'l' täht.");
            }

        }
    }
}
