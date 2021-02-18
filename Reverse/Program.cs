using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            string reverseCharacters = "";

            //Initial String
            Console.WriteLine("Please Enter a String");
            string characters = Console.ReadLine();
            length = characters.Length;

            //Reverse String Instructions 
            for (int i = length - 1; i >= 0; i--)
            {
                char singleLetter = characters[i];
                Console.Write(singleLetter);
                reverseCharacters += characters[i];
            }
            Console.Write("");

            //Check statement and reverse statement are equal
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