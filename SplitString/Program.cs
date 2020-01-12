using System;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText,inputChar;
            string[] splittedString;
            char splitChar;
            int splitCounter=0,splittedStringIndex=1;

            //METHODE FÜR STRING-SPLIT
            string[] StringSplitter(string text,char delimiter)
            {
                string[] value;
                int delCount = 1;
                int valueIndex = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == delimiter)
                    {
                        delCount++;
                    }
                }

                value = new string[delCount];

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == delimiter)
                    {
                        valueIndex++;
                    }
                    else
                    {
                        value[valueIndex] += text[j];
                    }
                }

                return value;
            }






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

            //SELBST VERFASST
            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == splitChar)
                {
                    splittedStringIndex++;
                }
            }

            splittedString = new string[splittedStringIndex];
            
            for (int k = 0; k < inputText.Length; k++)
            {
                if (inputText[k] == splitChar)
                {
                    Console.WriteLine(splittedString[splitCounter]);
                    splitCounter++;
                }
                else
                {
                    splittedString[splitCounter] += inputText[k];
                }
            }
            Console.WriteLine(splittedString[splitCounter]);

            //AUSGABE MIT DER VORGEFERTIGTEN SPLIT-METHODE
            splittedString = inputText.Split(splitChar);
            for (int j = 0; j < splittedString.Length; j++)
            {
                Console.WriteLine(splittedString[j]);
            }

            //AUSGABE MIT EIGENER METHODE
            splittedString = StringSplitter(inputText, splitChar);
            for (int m = 0; m < splittedString.Length; m++)
            {
                Console.WriteLine(splittedString[m]);
            }

        }
    }
}
