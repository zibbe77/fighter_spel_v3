using System;

Player p = new Player();

while (p.isAlive == true)
{
    Logic.GameControler(p);
}

Console.ReadLine();
