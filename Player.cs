using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    public interface IMovement
    {
        void Walk();       
        void Run();        
    }
    public interface IEmotion
    {
        void Happy();        
        void Sad();        
    }
    internal class Player : IMovement, IEmotion
    {
        public string PlayerName;
        public string PlayerDescription;

        public Player()
        {

        }

        public Player(string playerName, string playerDescription)
        {
            this.PlayerName = playerName;
            this.PlayerDescription = playerDescription;
        }

        public void GetDetail()
        {
            Console.WriteLine(
                $"Player name: {this.PlayerName}\n" +
                $"Description: {this.PlayerDescription}");
        }

        public void Run()
        {
            Console.WriteLine($"{this.PlayerName} is runing...");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.PlayerName} is walking...");
        }

        public void Happy()
        {
            Console.WriteLine($"{this.PlayerName} is happy...");
        }
        public void Sad()
        {
            Console.WriteLine($"{this.PlayerName} is sad...");
        }


    }
}
