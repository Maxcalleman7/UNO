using UNO;


class Program
{
    public static CardPile StartNewGame()

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
    public static void Main()
    {
        CardPile hiddenPile=StartNewGame();

        Console.WriteLine("PLAY UNO!");
        StartNewGame();

        

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
