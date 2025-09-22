using System.ComponentModel.Design;
using UNO;


class Program
{
    public static CardPile CreateDeck()

    {
        
        CardPile pile = new CardPile();
        pile.CreateNewCardPile();
        /*pile.GetFirstCard().ShowCard();*/ //test
        pile.ShuffleCards();
        
        return pile;
    }
    public static void  CreatePlayerDeck()
    {
        
    }

    public static bool CheckColorAndNumber(Card playerCards, Card topCard)
    {
        if (playerCards.color.Equals(topCard.color)|| playerCards.name.Equals(topCard.name)) return true;
        else return false;

    }


    public static void Main()
    {
        CardPile hiddenPile=CreateDeck();

        Console.WriteLine("PLAY UNO!");

        CreateDeck();
        CardPile playingPile = new CardPile();

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


         
        playingPile.PlaceCard(hiddenPile.PullCard(0));

        while (true)
        {
            for (int i = 0; i < handler.players.Count; i++)
            {
                Player currentPlayer = handler.players[i];
                Console.WriteLine($"\n{currentPlayer.name}'s turn:\n\n");
                Console.WriteLine("Top card is now: ");
                playingPile.GetFirstCard().ShowCard();
                
                bool cardsMatch=false;
                for (int j = 0; j < currentPlayer.playerdeck.cards.Count; j++)
                {
                    cardsMatch = CheckColorAndNumber(currentPlayer.playerdeck.cards[j], playingPile.GetFirstCard());
                    if (cardsMatch == true) 
                        break;
                }
                    if (cardsMatch == true)
                    {
                        

                        Card choosenCard= currentPlayer.ChooseAndPullCard();

                        bool chosenCardMatches=CheckColorAndNumber(choosenCard, playingPile.GetFirstCard());
                        if (chosenCardMatches == true)
                        {
                            playingPile.PlaceCard(choosenCard);
                            Console.WriteLine($"You played: {choosenCard.color} {choosenCard.name}");
                            currentPlayer.playerdeck.cards.Remove(choosenCard);
                            Console.WriteLine("Top card is now: ");
                            playingPile.GetFirstCard().ShowCard();
                        }
                        else
                        {
                            Console.WriteLine("You can't play that card, Draw a card instead");
                            Console.WriteLine($"You drew: ");
                        hiddenPile.cards[0].ShowCard();
                        currentPlayer.playerdeck.cards.Add(hiddenPile.PullCard(0));
                        }
                    }
                    else
                    {

                        Console.WriteLine("You can't play any card. Draw a card instead.");
                    Console.WriteLine($"You drew: ");
                    hiddenPile.cards[0].ShowCard();
                    currentPlayer.playerdeck.cards.Add(hiddenPile.PullCard(0));

                    }
                   
                    
                    
                





            }
        }


    }
    
}
