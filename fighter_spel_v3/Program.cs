using System;

Player p = new Player();

while (p.IsAlive == true)
{
    Logic.GameControler(p);
}

Console.ReadLine();
