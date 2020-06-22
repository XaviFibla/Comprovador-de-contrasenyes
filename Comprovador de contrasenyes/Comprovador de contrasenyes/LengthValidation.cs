using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Comprovador_de_contrasenyes
{
    public class LengthValidation
    {
        private const int MIN_LENGHT = 8;

        public LengthValidation() { }

        public bool Validate(string password)
        {
            return password.Length >= MIN_LENGHT;
        }
    }
}
