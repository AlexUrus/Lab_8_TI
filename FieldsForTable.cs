using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_TI
{
    public class FieldsForTable
    {
        public char Symbol { get; set; }
        public string DecCode { get; set; }
        public string BiCode { get; set; }
        public string HecaDecCode { get; set; }

        public FieldsForTable(char symbol) 
        {
            Symbol = symbol;
            DecCode = GetDecimalRepresentation(symbol);
            BiCode = GetBinaryRepresentation(symbol);
            HecaDecCode = GetHexadecimalRepresentation(symbol);
        }

        private string GetBinaryRepresentation(char c)
        {
            int value = (int)c;
            string binary = "";
            for (int i = 0; i < 8; i++)
            {
                binary = ((value & 1) == 1 ? "1" : "0") + binary;
                value >>= 1;
            }
            return binary;
        }

        private string GetDecimalRepresentation(char c)
        {
            int value = (int)c;
            return value.ToString();
        }

        private string GetHexadecimalRepresentation(char c)
        {
            int value = (int)c;
            return "0x" + value.ToString("X");
        }

    }
}
