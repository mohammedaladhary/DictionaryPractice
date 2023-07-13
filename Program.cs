namespace DictionaryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person person1 = new Person(1283, "Said", "Male");
            Person person2 = new Person(1827, "Ahmed", "Female");
            Person person3 = new Person(2938, "Hamed", "Male");

            Dictionary<long, Person> persons = new Dictionary<long, Person>();
            //persons.Add(person1.id, person1);
            //persons.Add(person2.id, person2);
            //persons.Add(person3.id, person3);

            persons[person1.id] = person1;
            persons[person2.id] = person2;
            persons[person3.id] = person3;

            person1.gender = "Female";
            persons[person1.id] = person1;
            //persons.TryAdd(person1.id, person1);
            Person? result = null;
            if(persons.TryGetValue(person1.id, out result))
            {
                Console.WriteLine(result);
            }
            //------------task1-wordFreqCounter-------------------------

            //getting the sentence
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            //counts the freq of each word
            Dictionary<string, int> wordFreq = wordFreqCounter.CountWords(sentence);

            //display the result
            wordFreqCounter.DisplayWordFreq(wordFreq);
        }
    }
}