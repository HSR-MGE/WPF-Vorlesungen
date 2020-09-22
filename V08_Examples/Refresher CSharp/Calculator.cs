using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_CSharp
{
    public class Calculator
    {
        public delegate int Calculation(int a, int b);

        public int Add(int a, int b) => a + b;

        public int Multiply(int a, int b) => a * b;
    }
}
