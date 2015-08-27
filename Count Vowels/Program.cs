using System;

namespace Count_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Josh's Vowel Counter!\n");

            Console.Write("Please enter a string that you would like me to count: ");
            string userInputString = Console.ReadLine();
            Console.WriteLine("\n");

            char[] vowelArray = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;

            foreach (char c in userInputString)
            {
                switch (c)
                {
                    case 'a':
                        countA++;
                        break;
                    case 'e':
                        countE++;
                        break;
                    case 'i':
                        countI++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    case 'u':
                        countU++;
                        break;
                }
            }

            Console.WriteLine("# of As: {0}", countA);
            Console.WriteLine("# of Es: {0}", countE);
            Console.WriteLine("# of Is: {0}", countI);
            Console.WriteLine("# of Os: {0}", countO);
            Console.WriteLine("# of Us: {0}", countU);

            // Pause the console so the user can read the information
            Console.WriteLine("\nThanks for using my program. Please press the Enter key to exit! :)");
            Console.ReadLine();
        }
    }
}
