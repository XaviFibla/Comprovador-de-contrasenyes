using System;

namespace Comprovador_de_contrasenyes
{
    class Program
    {
        
        static void Main(string[] args)
        {  
            Console.WriteLine("Password: ");
            var password = Console.ReadLine();
            var lengthValidation = new LengthValidation();

            if (lengthValidation.Validate(password))
                Console.WriteLine("OK");
            else
                Console.WriteLine("Longitud mínim de 8 caràcters");
        }
    }
}
