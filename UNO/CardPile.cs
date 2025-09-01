using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UNO
{
    internal class CardPile
    {
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow" }; 

        List<string> name = new List<string> { 
            "0", "1","1", "2","2", "3","3", "4","4", "5","5", "6","6", "7","7", "8","8", "9","9",
            "Block", "Block", "Reverse", "Reverse","Draw two","Draw two"};

        List<Card> cards = new List<Card>();

        public void CreateNewCardPile()
        {
            cards = new List<Card>();

            for (int i = 0; i < colors.Count; i++)
            {
                for (int j = 0; j < name.Count; j++)
                {
                    cards.Add(new Card(colors[i], name[j]));
                }
            }

            for(int k = 0; k < 4; k++)
            {
                cards.Add(new Card("Black", "Draw four"));
                cards.Add(new Card("Black", "Change color"));
            }
        }
        
        public void shuffleCardS()
        {
            Random rand = new Random();
            
        }


        //Add Card logic here
    }
}
