using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    internal class Calculator
    {
        public int x, y;
        public Calculator()
        {
            x = y = 0;
        }

        public Calculator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string Display()
        {
            return $"X: {this.x}, Y: {this.y}";
        }

        public int Addition() => x + y; 
        public int Subtraction() => x - y; 
        public int Multiplication() => x * y; 
        public int Division() => x / y; 
        public int Modulus() => x % y; 

        public int Action(string opertation)
        {
            switch(opertation)
            { 
                case "+" :
                    return x + y;
                case "-" :
                    return x - y;
                case "*" :
                    return x * y;
                case "/" :
                    return x / y;
                case "%" :
                    return x % y;
                default :
                    return 0;
            }
        }

        public static string operator +(Calculator calc1, Calculator calc2)
        {
            return $"X: {calc1.x + calc2.x}, Y: {calc1.y + calc2.y}";
        }

        public static string operator -(Calculator calc1, Calculator calc2)
        {
            return $"X: {calc1.x - calc2.x}, Y: {calc1.y - calc2.y}";
        }
    }
}
