using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comprovador_de_contrasenyes
{
    public class DigitsValidation
    {
        public DigitsValidation() { }

        public bool ContainsOnlyDigits(string password) {
            return !password.All(char.IsDigit);
        }
    }
}
