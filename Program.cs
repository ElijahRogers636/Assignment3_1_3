namespace Assignment3_1_3
{
    internal class Program
    {
        // Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence to amount of spaces in the sentence");
            Console.Write("Here: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"\nSentence: { sentence }");
            Console.WriteLine($"\nSpaces: { CountSpacesInSentence(sentence) }");

        }

        // Counts the spaces within a provided sentence and returns the number of spaces
        static int CountSpacesInSentence(string sentence)
        {
            int count = 0;
            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    count++;
                }

            }
            return count;
            
        }
    }
}
