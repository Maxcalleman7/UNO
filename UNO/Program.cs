using UNO;


class Program
{
    public static CardPile CreateDeck()

    {
        
        CardPile pile = new CardPile();
        pile.CreateNewCardPile();
        pile.GetFirstCard().ShowCard(); //test
        pile.ShuffleCards();
        
        return pile;
    }
    public static void  CreatePlayerDeck()
    {
        
    }

    public static bool CheckColorAndNumber(Card playerCards, Card topCard)
    {
        if (playerCards.color.Equals(topCard)|| playerCards.name.Equals(topCard)) return true;
        else return false;

    }
    public static void Main()
    {
        CardPile hiddenPile=CreateDeck();

        Console.WriteLine("PLAY UNO!");
        CreateDeck();
        

        PlayerHandler handler = new PlayerHandler();
        int numPlayers = handler.NumberOfPlayers();
        handler.CreatePlayers(numPlayers);

        for (int i = 0; i < numPlayers; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                handler.players[i].playerdeck.cards.Add(hiddenPile.PullCard(0));
            }
        }

    }
    
}
