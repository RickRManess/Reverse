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
            Console.Write("");

            //Check statement and reverse statement are equal
            for (int i = length - 1; i >= 0; i--)
            {
                char[] arr = { characters[i] };
                string reverse = new string(arr);
            }



        }


    }

}