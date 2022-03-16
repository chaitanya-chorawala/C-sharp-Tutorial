using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    internal class Rectangle
    {
        private decimal length;
        private decimal width;

        public decimal Length
        {
            get
            {
                return length;
            }
            set 
            { 
                length = value > 0 && value < 20 ? value : 0; 
            }
        }

        public decimal Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value > 0 && value < 20 ? value : 0;
            }
        }

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public void Display() => Console.WriteLine($"Length: {Length} \nWidth: {Width}");
        public void Area() => Console.WriteLine("Area: " + (length * width));
        public void Perimeter() => Console.WriteLine("Perimeter: " + 2 * (length + width));
    }
}
