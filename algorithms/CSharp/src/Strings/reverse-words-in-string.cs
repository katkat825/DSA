using System;

//Time Complexity: O(n)
namespace Algorithms.Strings
{
    public class ReverseWordsInString
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a string");
            string originalString = Console.ReadLine();

            Console.WriteLine(ReverseWords(originalString));
        }

        //Reverse the order of the words in a given string
        //Example: "Hello World" becomes "World Hello"
        public static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            
            Array.Reverse(words);

            string reversedString = string.Join(" ", words);

            return reversedString;
        }
    }
}
