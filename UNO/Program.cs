using UNO;


class Program
{
    public static void Main()
    {
        Console.WriteLine("PLAY UNO!");

        

        CardPile pile = new CardPile();
        pile.CreateNewCardPile();
        pile.GetFirstCard().ShowCard();
        pile.ShuffleCards();
        
    }
}