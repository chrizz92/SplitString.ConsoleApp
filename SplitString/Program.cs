using System;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText,inputChar;
            char splitChar;
            int splitCounter=0;

            Console.WriteLine("Strings trennen");
            Console.WriteLine("===============");
            Console.Write("Bitte Text eingeben: ");
            inputText = Console.ReadLine();
            do
            {
                Console.Write("Bitte Trennzeichen eingeben: ");
                inputChar = Console.ReadLine();
            } 
            while (inputChar.Length > 1);

            splitChar = Convert.ToChar(inputChar);

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == splitChar)
                {
                    splitCounter++;
                }
            }

            string[] splittedString = inputText.Split(splitChar, splitCounter);

            for (int j = 0; j < splittedString.Length; j++)
            {
                Console.WriteLine(splittedString[j]);
            }
        }
    }
}
