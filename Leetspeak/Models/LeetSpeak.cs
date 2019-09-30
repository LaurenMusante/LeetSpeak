using System;
using System.Collections.Generic;
namespace Translator 
{
    class Leetspeak
    {
        static void Main()
        {

        }
        public static string LeetConverter(string userPhrase)
        {
            // char[] v = new char[userPhrase.Length];
            char[] userInputArray = userPhrase.ToCharArray();
            string output = "";
            for (int i = 0; i < userInputArray.Length; i++)
            {
                if (userInputArray[i] == 'e' || userInputArray[i] == 'E')
                {
                    output += "3";
                }
                else if (userInputArray[i] == 'o' || userInputArray[i] == 'O')
                {
                    output += "0";
                }
                else if (userInputArray[i] == 'I')
                {
                    output += "1";
                }
                else if (userInputArray[i] == 't' || userInputArray[i] == 'T')
                {
                    output += "7";
                }
                else if (i!=0 && (userInputArray[i] == 's' || userInputArray[i] == 'S'))
                {
                    output += 'z';
                }
                else 
                {
                    output += userInputArray[i];
                }
            }

        }
        
    }
}

// Leetspeak
// Leetspeak uses an alternative alphabet of numbers and symbols to replace various letters in words. For example, "leet" becomes "1337" and "Epicodus" might become "3pic0duz".

// Write a LeetspeakTranslator class with a Translate() method that translates a provided string into Leetspeak using the following rules:

// "e" should be replaced with "3".
// "o" should be replaced with "0".
// Capital (not the lowercase "I" should be replaced with "1".
// "t" should be replaced with "7".
// "s" should be replaced with "z", unless it is the first letter of a word.
// Here's what sample input and output from a complete program should look like:

// Input: "Don't you love these 'String' exercises? I do!"
// Output: "D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!"
// Hints
// A string can be turned into an array using the ToCharArray() method:
// char[] array = "hello".ToCharArray();
// An Array can be transformed into a String using the Join() method:
// string result = string.Join("", array);