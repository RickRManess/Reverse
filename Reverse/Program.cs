using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;

            //Initial String
            Console.WriteLine("Please Enter a String");
            string characters = Console.ReadLine();
            length = characters.Length;

            //Reverse String Instructions 
            for (int i = length - 1; i >= 0; i--)
            {
                char singleLetter = characters[i];
                Console.Write(singleLetter);
            }
            // Palindrome test for string 
            string reverseCharacters = " ";
            for (int i = reverseCharacters.Length - 1; i > 0; i--)
            {
                reverseCharacters += characters[i];
            }
            if (characters.Equals(reverseCharacters, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.Write(" Thats a palindrome");
            }
            else
            {
                Console.WriteLine("");
                Console.Write("Thats not a palindrome");
            }
        }
    }

}