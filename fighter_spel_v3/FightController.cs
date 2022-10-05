using System;

public class FightController
{
    //kör turer i fighten
    public static void FightTurnController(Player p)
    {
        //metod för att bestäma styrkan av finden 
        Enemy e = new Enemy();

        //kollar vem  spm går först
        List<Fighter> turnOrder = new List<Fighter>();
        turnOrder.Add(p);
        turnOrder.Add(e);

        bool controler = true;
        while (controler == true)
        {
            //kola om det fungerar med fler om. Borde inte fungera.
            turnOrder[0].Attack(turnOrder[1]);
            turnOrder[1].IsAlive();

            //kollar om den ska in i tur igen 
            if (turnOrder[0].isAlive == true)
            {
                turnOrder.Add(turnOrder[0]);
            }
            turnOrder.RemoveAt(0);

            //kollar om loopen ska avslutas 
            foreach (Fighter f in turnOrder)
            {
                if (f.isAlive == false)
                {
                    controler = false;
                }
                Console.WriteLine("hello");
            }

            //test 
            Console.ReadLine();

            // skriv stats
        }
    }

}