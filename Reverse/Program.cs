using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;

            //Initial String
            Console.WriteLine();
            Console.Clear();
            string characters = Console.ReadLine();
            length = characters.Length;

            //Reverse String Instructions 
            
                for (int i = length - 1; i >= 0; i--)
                {
                    char singleLetter = characters[i];
                    Console.Write(singleLetter);
                
                }
                    // Palindrome test for string 




                
            
        }

    }

}