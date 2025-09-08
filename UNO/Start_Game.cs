using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    internal class Start_Game
    {
        CardPile cardPile = new CardPile();
        public void StartNewGame()
        {
            cardPile.CreateNewCardPile();
            cardPile.ShuffleCards();
        }
    }
}
