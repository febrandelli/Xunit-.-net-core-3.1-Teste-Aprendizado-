using System;
using System.Collections.Generic;
using System.Text;

namespace Teste
{
    public interface ICalculator
    {
        decimal Add(int number1, int number2);
        decimal Subtraction(int number1, int number2);
        decimal Division(int number1, int number2);
        decimal Multiplication(int number1, int number2);
    }
}
