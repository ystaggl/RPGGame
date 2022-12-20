// See https://aka.ms/new-console-template for more information

using System.Net.Mail;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using RPG_Game;
Console.WriteLine("What is your name?");
var player = new Player(Console.ReadLine());
var dragon = new FightingEntity("Dragon",100,20);
while (!player.IsDead() || !dragon.IsDead())
{
    player.Attack(dragon);
    Console.WriteLine($"Dragon health: {dragon.hitPoints}");
    if (dragon.IsDead())
    {
        break;
    }
    dragon.Attack(player);
    Console.WriteLine($"Player health: {player.hitPoints}");
}

switch (player.IsDead())
{
    case true:
        Console.WriteLine("Game over. You lose.");
        return;
    case false:
        Console.WriteLine("You win!");
        return;
}