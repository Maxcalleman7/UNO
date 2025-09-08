using UNO;


class Program
{
    public static void StartNewGame()

    {
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
