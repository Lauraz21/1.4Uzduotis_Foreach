namespace _1._4Uzduotis_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] result = ReturnSentence(sentence);
            
            foreach (string tot in result)
            {
                Console.WriteLine(tot);
            }

        }
        public static string[] ReturnSentence(string sentence)
        {
            string[] newSentence = sentence.Split(' ');
            string[] sentenceReturn = new string[sentence.Length];
            int index = 0;
            foreach (string item in newSentence)
            {
                if (item.Length >= 5)
                {
                    sentenceReturn[index] = item;
                    index++;
                }
            }
            return sentenceReturn;
        }
    }
}