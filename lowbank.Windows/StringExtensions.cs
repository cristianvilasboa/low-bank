using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowbank.Windows
{
    public static class StringExtensions
    {
        public static decimal ConvertDecimalString(this string decimalString)
        {
            List<char> decimalChars = new List<char>();

            foreach (char caracter in decimalString)
            {
                //  Validar se é número ou . ou ,
                if (caracter == '.' || caracter == ',' || char.IsDigit(caracter))
                {
                    // Usa esse caracter
                    decimalChars.Add(caracter);
                }
            }

            string textoSaldo = new string(decimalChars.ToArray());

            decimal saldo = decimal.Parse(textoSaldo);
            return saldo;
        }
    }
}
