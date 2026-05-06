namespace FantasyCardArena.Domain.Abilities;

public interface IAbility
{
    void OnTurnStart(CardInstance owner);
    void OnDealDamage(CardInstance owner, CardInstance target, ref int damage);
    void OnReceiveDamage(CardInstance owner, CardInstance attacker, ref int damage);
    void OnDeath(CardInstance owner);
}
