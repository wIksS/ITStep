
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCounter
{
    public class WordsCounter : IWordsCounter
    {
        public Dictionary<string, int> Count(string text)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            string[] splittedText = text.Split(new char[] { ' ', ',', '!', '?', ':', '\"', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splittedText.Length; i++)
            {
                if (!words.ContainsKey(splittedText[i]))
                {
                    words.Add(splittedText[i], 1);
                }
                else
                {
                    words[splittedText[i]] = words[splittedText[i]] + 1;
                }
            }

            return words;
        }
    }
}
