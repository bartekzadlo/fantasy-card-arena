namespace FantasyCardArena.Domain;

public class Hand
{
    private List<CardInstance> _cards = new();
    public const int MaxSize = 3;
    
    public IReadOnlyList<CardInstance> Cards => _cards;
    public bool IsFull => _cards.Count >= MaxSize;

    public void Add(CardInstance card)
    {
        if (IsFull) return;
        _cards.Add(card);
    }

    public CardInstance? Play(int index)
    {
        if (index < 0 || index >= _cards.Count) return null;

        var card = _cards[index];
        _cards.RemoveAt(index);
        return card;
    }
}
