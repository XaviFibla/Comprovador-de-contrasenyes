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
            var digitValidation = new DigitsValidation();

            if (!lengthValidation.Validate(password))
            {
                Console.WriteLine("Longitud mínim de 8 caràcters");
            }
            if (digitValidation.ContainsOnlyDigits(password))
            {                 
                Console.WriteLine("La contrasenya ha de contenir lletres i dígits"); 
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
