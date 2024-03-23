using PlayingCards.Model;

namespace PlayingCards;

internal class Program {
    public static void Main(string[] args) {
        Card[] deck = GenerateFrenchDeck();

        for (int i = 0; i < deck.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {deck[i]}");
        }

        Console.ReadKey();
    }
    
    private static Card[] GenerateFrenchDeck() {
        Card[] deck = new Card[52];
        int index = 0;

        foreach (var suit in Enum.GetValues<Suit>()) {
            AddNumberedCards(deck, ref index, suit);
            AddCourtCards(deck, ref index, suit);
        }
        return deck;
    }
    
    private static void AddNumberedCards(Card[] deck, ref int index, Suit suit) {
        for (int i = 2; i <= 10; i++) {
            Card card = new Card(i.ToString(), suit);
            deck[index] = card;
            index++;
        }
    }
    
    private static void AddCourtCards(Card[] deck, ref int index, Suit suit) {
        string[] courtSymbols = { "Jack", "Queen", "King", "Ace" };

        foreach (var courtSymbol in courtSymbols) {
            Card card = new Card(courtSymbol, suit);
            deck[index] = card;
            index++;
        }
    }
}