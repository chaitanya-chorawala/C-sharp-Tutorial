using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    public class TestVirtual 
    { 
        public virtual void Display()
        {
            Console.WriteLine("Parent display");
        }
    }
    internal class Car : TestVirtual
    {
        public String Company { get; set; }
        private String modelName;
        public String Model 
        { 
            get
            {
                return Company + "\'s " + modelName;
            } 
            set { 
                modelName = value;
            } 
        }
        public int Year { get; set; }
        public String Color { get; set; }        

        public decimal DetermineMarketValue()
        {
            decimal value = 0;

            if (Year > 1999) value = 100000;
            else value = 50000;
            
            return value;
        }

        public override void Display()
        {
            Console.WriteLine("Child display");
        }
    }
}
