using System;
using System.Collections.Generic;

public class Interface
{
    protected int option { get; set; }
    public void Menu()
    {    
        Console.WriteLine($"01 - Comprar.");
        Console.WriteLine($"02 - Vender.");
        Console.WriteLine($"03 - Reposicionar.");
        Console.WriteLine($"04 - Iniciar.");
        option = Convert.ToInt32(Console.ReadLine());
        

    }
    public void Selector()
    {
        switch(option)
        {
            case 1:
                Game.Current.Buy(/* IMPLEMENTAR OS PARAMETROS AQUI */);
                break;
        }
    }
}

public class Game
{
    private Game() {}
    private static Game crr = null;
    public static Game Current => crr;
    public int Money { get; set; } = 10;
    public Team team = new Team();
    protected int round { get; set; }
    public void Buy(int index, int index2)
    {
        if(WorkShop.Current.GetBoneco(index) == team.GetTeam(index2) || team.GetTeam(index2) == null)
            if(this.Money >= 3 && WorkShop.Current.SellBoneco(index) != null) 
            { 
                this.Money -= 3;
                team.AddBoneco(WorkShop.Current.SellBoneco(index));
            }
    }
    public void Sell(int index)
    {
        var temp = team.GetTeam(index).GetLevel();
        Money += team.PopBoneco(index) ? temp : 0;
    } 
    
}