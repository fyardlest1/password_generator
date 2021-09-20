using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordGenerator
{
    static class Tools
    {
        public static int PositiveNotNullNumber(string question)
        {
            return ValidNumber(question, 1, int.MaxValue);
        }

        static int ValidNumber(string question, int min, int max)
        {

            int number = AskForNumber(question);
            if ((number >= min) && (number <= max))
            {
                return number;
            }
            Console.WriteLine($"The number should be between {min} and {max}");

            return ValidNumber(question, min, max);
        }

        static int AskForNumber(string question)
        {
            while (true)
            {
                // poser la question
                Console.Write(question);
                // recuperer la reponse
                string respose = Console.ReadLine();
                // gestion d'erreur de conversion                
                try
                {
                    int passLengthNum = int.Parse(respose);
                    return passLengthNum;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter a number.");
                }
            }
        }
    }
}
