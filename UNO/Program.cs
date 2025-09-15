using UNO;


class Program
{
    public static void StartNewGame()

    {
        PlayerHandler handler = new PlayerHandler();
        int numPlayers = handler.NumberOfPlayers();


        handler.CreatePlayers(numPlayers);

        CardPile pile = new CardPile();
        pile.CreateNewCardPile();
        pile.ShuffleCards();
    }
    public static void Main()
    {
        Console.WriteLine("PLAY UNO!");
        StartNewGame();



    }
}
