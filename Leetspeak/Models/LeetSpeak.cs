using System;
using System.Collections.Generic;

namespace LeetSpeak 
{
    public class LeetSpeak
    {
        static void Main()
        {

        }
        public string LeetConverter(string userPhrase)
        {
            Dictionary<char,string> leetDict = new Dictionary<char,string>(){{'e', "3"}, {'E', "3"},{'o', "0"},{'O', "0"},{'I', "1"},{'t', "7"},{'T',"7"}};
            char[] userInputArray = userPhrase.ToCharArray();
            string output = "";
            for (int i = 0; i < userInputArray.Length; i++)
            {
                char currentCharacter = userInputArray[i];
                char[] specialLetters = leetDict.Keys.ToList();  //specialLetters is an array of the Keys of the leetDict.
                if(specialLetters.Contains(currentCharacter))
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
