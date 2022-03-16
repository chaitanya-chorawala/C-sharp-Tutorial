using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    public abstract class Vehicle
    {
        protected bool IsPetrol {  get; set; } 
        protected string Name { get; set; }
        protected int NoOfWheel { get; set; }        

        public abstract void Start();
        public abstract void Stop();
        public abstract void TurnLeft();
        public abstract void TurnRight();        
    }

    #region Bike
    public class Bike : Vehicle
    {
        public Bike()
        {

        }

        public Bike(bool IsPetrol, string Name, int NoOfWheel)
        {
            this.IsPetrol = IsPetrol;
            this.Name = Name;
            this.NoOfWheel = NoOfWheel;
        }       

        public override string ToString()
        {
            return
                $"Name        : {this.Name}\n" +
                $"Is Petrol?  : {this.IsPetrol}\n" +
                $"No of wheel : {this.NoOfWheel}";
        }

        public override void Start()
        {
            Console.WriteLine($"{this.Name} is starting...");
        }

        public override void Stop()
        {
            Console.WriteLine($"{this.Name} is stoped...");
        }

        public override void TurnLeft()
        {
            Console.WriteLine($"{this.Name} is turning left...");
        }

        public override void TurnRight()
        {
            Console.WriteLine($"{this.Name} is turning right...");
        }
    }
    #endregion

    #region Rikshaw
    public class Rikshaw : Vehicle
    {
        public Rikshaw()
        {

        }

        public Rikshaw(bool IsPetrol, string Name, int NoOfWheel)
        {
            this.IsPetrol = IsPetrol;
            this.Name = Name;
            this.NoOfWheel = NoOfWheel;
        }

        public override string ToString()
        {
            return
                $"Name        : {this.Name}\n" +
                $"Is Petrol?  : {this.IsPetrol}\n" +
                $"No of wheel : {this.NoOfWheel}";
        }

        public override void Start()
        {
            Console.WriteLine($"{this.Name} is starting...");
        }

        public override void Stop()
        {
            Console.WriteLine($"{this.Name} is stoped...");
        }

        public override void TurnLeft()
        {
            Console.WriteLine($"{this.Name} is turning left...");
        }

        public override void TurnRight()
        {
            Console.WriteLine($"{this.Name} is turning right...");
        }
    }
    #endregion

    #region Truck
    public class Truck : Vehicle
    {
        public Truck()
        {

        }

        public Truck(bool IsPetrol, string Name, int NoOfWheel)
        {
            this.IsPetrol = IsPetrol;
            this.Name = Name;
            this.NoOfWheel = NoOfWheel;
        }

        public override string ToString()
        {
            return
                $"Name        : {this.Name}\n" +
                $"Is Petrol?  : {this.IsPetrol}\n" +
                $"No of wheel : {this.NoOfWheel}";
        }

        public override void Start()
        {
            Console.WriteLine($"{this.Name} is starting...");
        }

        public override void Stop()
        {
            Console.WriteLine($"{this.Name} is stoped...");
        }

        public override void TurnLeft()
        {
            Console.WriteLine($"{this.Name} is turning left...");
        }

        public override void TurnRight()
        {
            Console.WriteLine($"{this.Name} is turning right...");
        }
    }
    #endregion

}
