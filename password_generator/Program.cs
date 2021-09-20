using passwordGenerator;
using System;

namespace password_generator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int passLength = Tools.PositiveNotNullNumber("Password length: ");
            Console.WriteLine(passLength);
        }

    }
}
