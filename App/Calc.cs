using System;
namespace App
{
    public class Calc
    {
        public Calc()
        {
        }

        public int Valor1
        {
            get;
            set;

        }

        public int Valor2
        {
            get;
            set;
        }

        public int Soma(int val1, int val2)
        {
            return val1 + val2;
        }
        public int Subtracao()
        {
            return Valor1 - Valor2;
        }
    }
}
