using System;

namespace Comprovador_de_contrasenyes
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Password: ");
            var password = Console.ReadLine();

            var passwordValidation = new PasswordValidation();
            if (!passwordValidation.ValidatePassword(password, out string error))
                Console.WriteLine(error);
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
