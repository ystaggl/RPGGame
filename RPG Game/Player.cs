using System.Security.Cryptography;

namespace RPG_Game;

public class Player : FightingEntity
{
    public Player(string name="Player",int hitPoints=100,int damage=20) : base(name, hitPoints, damage)
    {
        
    }
}