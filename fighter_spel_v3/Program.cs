using System;

Player p = new Player();

public static bool exit = true;

while (true)
{
    Logic.GameControler(p);
}

//Enemy e = new Enemy();
//p.Attack(e);
// Sword s = new Sword();
// Weapon w = new Weapon();
// Weapon w2 = new Sword();
// w2.Attack(new Fighter());

Console.ReadLine();
