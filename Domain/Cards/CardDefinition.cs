namespace FantasyCardArena.Domain.Cards;

public class CardDefinition
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Delay { get; set; }
    public List<IAbility> Abilities { get; set; }
}
