using System;
using System.ComponentModel.DataAnnotations;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define varaibles;
            string searchTerm;
            string sentence;
            string newSentence;
            int index, length;
           
            //Store the sentence to sentence variable;
            sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'".ToLower();
           
            //Add a print line to prompt the user for the search item and store user's input to searchItem
            Console.WriteLine("Please enter the word you search for:");
            searchTerm = Console.ReadLine().ToLower();

            //Add condition statement to get the search result
            Console.WriteLine("Search term was found: " + (sentence.IndexOf(searchTerm) >= 0).ToString().ToLower());

            //Add a conditional statement to check whether search term in the sentence
            if (sentence.IndexOf(searchTerm) >=0)
            {
                index = sentence.IndexOf(searchTerm);
                length = searchTerm.Length;
                Console.WriteLine("Index is " + index.ToString() + ", the word's length is " + length);

                //Remove the word and define a new varible to store the new string

                newSentence = sentence.Replace(searchTerm, "");
                Console.WriteLine(newSentence);
            }





        }
    }
}
