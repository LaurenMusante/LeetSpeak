using System;
using System.Collections.Generic;

namespace LeetSpeak 
{
    public class LeetSpeak
    {
        static void Main()
        {
            AskLeet();
        }

        public static void AskLeet()
        {
            Console.WriteLine("Give us your phrase!");
            string userInput = Console.ReadLine();
            LeetSpeak newLeetSpeak = new LeetSpeak();
            Console.WriteLine(newLeetSpeak.LeetConverter(userInput));
            AskLeet();
        }
        public string LeetConverter(string userPhrase)
        {
            Dictionary<string,string> leetDict = new Dictionary<string,string>(){{"e", "3"}, {"E", "3"},{"o", "0"},{"O", "0"},{"I", "1"},{"t", "7"},{"T","7"}};
            char[] userInputArray = userPhrase.ToCharArray();
            string output = "";
            for (int i = 0; i < userInputArray.Length; i++)
            {
                string currentCharacter = userInputArray[i].ToString();
                List<string> specialLetters = new List<string>(leetDict.Keys); //specialLetters is an array of the Keys of the leetDict.
                if(specialLetters.Contains(currentCharacter)) //.Contains must compare 2 strings, cannot use chars
                {
                    output += leetDict[currentCharacter];
                }
                //leetDict[currentCharacter] gives us the value according to the key from above. The keys are defined in char[] specialLetters = leetDict.Keys.ToList()
                else if (i!=0 && (userInputArray[i] == 's' || userInputArray[i] == 'S'))
                {
                    output += "z";
                }   
                else 
                {
                    output += userInputArray[i];
                }
            }
            return output;
        }
        
    }
}
