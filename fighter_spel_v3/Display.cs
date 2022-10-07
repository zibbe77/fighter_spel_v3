using System;


public class Display
{
    public static void Line(string text, int option)
    {

        //ökar boxen om text är längre än 38 tecken
        int extraDash = 38 - text.Length;
        string dash = "";
        if (extraDash < 0)
        {
            for (int i = 0; i < MathF.Abs(extraDash); i++)
            {
                dash += "-";
            }
        }

        //centerar texten 
        string space = "";
        for (int i = 0; i < (38 - text.Length) / 2; i++)
        {
            space += " ";
        }

        //skriver utt medlandet 
        System.Console.WriteLine($"----------------------------------------{dash}");
        System.Console.WriteLine($"|{space}{text}{space}|");
        if (option == 0)
        {
            System.Console.WriteLine($"----------------------------------------{dash}");
        }
    }
    //skriver utt vad dinna val är 
    public static void Choice()
    {
        string text = "Vad vill du göra? Skriv det du vill göra";
        Display.Line(text, 1);
        string text2 = "Slåss | Shop | livs statistik";
        Display.Line(text2, 0);
    }
    public static void Stats(Player p)
    {
        string text = "Du tar skade i den årdningen dom skrivs ut";
        Line(text, 1);
        string shildText = $"Shild - {p.maxBaseShield} av {p.baseShield} max";
        Line(shildText, 1);
        string armorText = $"Armor - {p.maxBaseArmor} av {p.baseArmor} max";
        Line(armorText, 1);
        string hpText = $"Hp - {p.hp} av {p.maxHp} max";
        Line(hpText, 0);
    }
}
