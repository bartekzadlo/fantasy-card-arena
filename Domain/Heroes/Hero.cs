namespace FantasyCardArena.Domain.Heroes;

public class Hero
{
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int CurrentHealth { get; set; }
    public bool IsAlive => CurrentHealth > 0;

    public Hero(string name, int health)
    {
        Name = name;
        MaxHealth = health;
        CurrentHealth = health;
    }
}
