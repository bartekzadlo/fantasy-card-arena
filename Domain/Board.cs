namespace FantasyCardArena.Domain;

public class Board
{
    private List<CardInstance> _cards = new();
    public const int MaxSize = 15;
    
    public IReadOnlyList<CardInstance> Cards => _cards;
    public bool IsFull => _cards.Count >= MaxSize;

    public bool Play(CardInstance card)
    {
        if (IsFull) return false;
        _cards.Add(card);
        return true;
    }

    public void Remove(CardInstance card) => _cards.Rremove(card);

    public void Shift()
    {
        _cards = _cards.Where(c => c.IsAlive).ToList();
    }

    public CardInstance? GetOpponent(int index, Board enemyBoard)
    {
        if (index < 0 || index >= enemyBoard.Cards.Count) return null;
        return enemyBoard.Cards[index];
    }
}
