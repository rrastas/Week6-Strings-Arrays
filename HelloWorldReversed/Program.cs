using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            string fullSentence = "Hello World!";

           /* Console.WriteLine("Sisesta lause:");        
              string fullSentence = Console.ReadLine(); */

            for (int i = fullSentence.Length - 1; i >= 0; i--)
            {
                Console.Write(fullSentence[i]);
            }

        }
    }
}
