using passwordGenerator;
using System;

namespace password_generator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // nbre de mots de passe a generer
            const int TOTAL_PASSWORD = 10;

            int passwordLength = Tools.PositiveNotNullNumber("Password length: ");
            Console.WriteLine();

            int alphabetChoice = Tools.ValidNumber("Do you want a password with:\n" +
                " 1- Lower Characters Only?\n" +
                " 2- Lower And Upper Characters?\n" +
                " 3- Lower Characters + Upper Characters + Numbers?\n" +
                " 4- Lower Characters + Upper Characters + Numbers + Special Characters?\n" +
                "Your choice: ", 1, 4);

            string lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string upperAlphabet = lowerAlphabet.ToUpper();
            string numbers = "0123456789";
            string specialChars = "#&$+-.,";
            string alphabet;
            string passWord = "";            
            Random rand = new Random();
            
            if (alphabetChoice == 1)
                alphabet = $"{lowerAlphabet}";
            else if (alphabetChoice == 2)
                alphabet = $"{lowerAlphabet}{upperAlphabet}";
            else if (alphabetChoice == 3)
                alphabet = $"{lowerAlphabet}{upperAlphabet}{numbers}";
            else
                alphabet = $"{lowerAlphabet}{upperAlphabet}{numbers}{specialChars}";

            int alphabetLength = alphabet.Length;
            
            for (int i = 0; i < TOTAL_PASSWORD; i++)
            {
                passWord = "";
                // boucler sur longueur mot de passe
                for (int j = 0; j < passwordLength; j++)
                {
                    int index = rand.Next(0, alphabetLength);
                    passWord += alphabet[index];                    
                }

                Console.WriteLine($"Passsword : {passWord}");
            } 
        }

    }
}
