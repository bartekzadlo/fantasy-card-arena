namespace FantasyCardArena.Domain;

public class Deck
{
    private List<CardDefinition> _cards = new();
    public int Count => _cards.Count;
    public void Add(CardDefintion card) => _cards.Add(card);

    public void Shuffle()
    {
        var rng = new Random();
        _cards = _cards.OrderBy(_ => rng.Next()).ToList();
    }

    public CardDefinition? Draw()
    {
        if (_cards.Count == 0) return null;

        var card = _cards[0];
        _cards.RemoveAt(0);
        return card;
    }
}
