using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class PlayerHandler
    {

        public List<Player> players {  get; private set; }
        public PlayerHandler() 

        {
            players = new List<Player>();


        }

        public int NumberOfPlayers() //Hämta antalet spelare
        {
            try
            {
                Console.WriteLine("Enter number of players (2-4): ");
                int numPlayers = int.Parse(Console.ReadLine());
                while (numPlayers < 2 || numPlayers > 4)
                {
                    Console.WriteLine("Invalid number of players. Please enter a number between 2 and 4: ");
                    numPlayers = int.Parse(Console.ReadLine());
                }
                return numPlayers;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number between 2 and 4.");
                return NumberOfPlayers();

                
            }
        }

        List<Player> players = new List<Player>();

        public void CreatePlayers(int numPlayers) //Skapa spelare
        {

            for (int i = 0; i < numPlayers; i++)
            {
                Player player = new Player();
                player.GetName();
                players.Add(player);

            }
        } 

    }
}
