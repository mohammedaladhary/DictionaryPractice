using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    internal class wordFreqCounter
    {
        //count the frequency of each word in a sentence
        public static Dictionary<string, int> CountWords(string sentence)
        {
            // Create an empty dictionary to store the word frequencies
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            // Split the sentence into words by whitespace and punctuation characters
            string[] words = sentence.Split(new char[] { ' ', ',', '.', '?', '!', ':', ';', '"', '\'', '(', ')', '[', ']', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            // Loop through each word in the array
            foreach (string word in words)
            {
                // Convert the word to lowercase for case-insensitive comparison
                string lowerWord = word.ToLower();

                // If the word is already in the dictionary, increment its frequency by one
                if (wordFreq.ContainsKey(lowerWord))
                {
                    wordFreq[lowerWord]++;
                }
                // Otherwise, add the word to the dictionary with a frequency of one
                else
                {
                    wordFreq.Add(lowerWord, 1);
                }
            }

            // Return the dictionary of word frequencies
            return wordFreq;
        }

        // A method that displays the dictionary of word frequencies in a formatted way
        public static void DisplayWordFreq(Dictionary<string, int> wordFreq)
        {
            Console.WriteLine("The word frequencies are:");

            // Loop through each key-value pair in the dictionary
            foreach (KeyValuePair<string, int> pair in wordFreq)
            {
                // Print the key (word) and the value (frequency) separated by a colon
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}