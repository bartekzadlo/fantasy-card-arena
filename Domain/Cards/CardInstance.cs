namespace FantasyCardArena.Domain.Cards;

public class CardInstance
{
    public CardDefinition Definition { get; }
    public int CurrentHealth { get; set; }
    public int CurrentDelay { get; set; }
    public bool IsActive => CurrentDelay == 0;
    public bool IsAlive => CurrentHealth > 0;
    
    public CardInstance(CardDefinition definition)
    {
        Definition = definition;
        CurrentHealth = definition.Health;
        CurrentDelay = definition.Delay;
    }
}
