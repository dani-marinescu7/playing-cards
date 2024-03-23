namespace PlayingCards.Model;

public class Card {
    public Suit Suit { get; set; }
    public string Symbol { get; set; }
    public Card(string symbol, Suit suit) {
        this.Symbol = symbol;
        this.Suit = suit;
    }
}