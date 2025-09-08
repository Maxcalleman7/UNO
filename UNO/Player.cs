using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Player
    {
        private string name { get; set; }
        public Player() //spelarkonstruktor
        {

        }

        
       public string GetName() //Hämta spelarens namn
        {
           
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please enter a valid name: ");
                name = Console.ReadLine();
            }
            
            return name;
        }

    }
}
