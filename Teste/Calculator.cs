using System;
using System.Collections.Generic;
using System.Text;

namespace Teste
{
    public class Calculator : ICalculator
    {
        public decimal Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public decimal Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public decimal Division(int number1, int number2)
        {
            return number1 / number2;
        }

        public decimal Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }        
    }
}
