namespace RPG_Game;

public class FightingEntity
{
    public int hitPoints;
    public int damage;
    public string name;

    public FightingEntity(string name="", int hitPoints=0, int damage=0)
    {
        this.name = name;
        this.damage = damage;
        this.hitPoints = hitPoints;
    }

    public virtual void Attack(FightingEntity attackVictim)
    {
        attackVictim.TakeDamage(this.damage);
        Console.WriteLine($"{this.name} Attacks!");
        if (attackVictim.IsDead())
        {
            Console.WriteLine($"{attackVictim.name} has been slain.");
        }
    }

    private void TakeDamage(int damageTaken) => this.hitPoints -= damageTaken;

    public bool IsDead() => this.hitPoints <= 0;
}