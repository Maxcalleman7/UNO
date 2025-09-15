using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Player
    {
        public string name { get; private set; }

        public CardPile playerdeck { get; set; }

        public Player() //spelarkonstruktor
        {
            playerdeck= new CardPile();
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
