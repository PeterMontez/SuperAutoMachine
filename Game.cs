using System;
using System.Collections.Generic;

public class Interface
{
    public int Menu()
    {    
        Console.WriteLine($"01 - Comprar.");
        Console.WriteLine($"02 - Vender.");
        Console.WriteLine($"03 - Reposicionar.");
        Console.WriteLine($"04 - Iniciar.");

        return Convert.ToInt32(Console.ReadLine());
    }
    public void Selector(int option)
    {
        switch(option)
        {
            case 1:
                Console.WriteLine(WorkShop.Current);
                int shopIndex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Game.Current.team);
                int teamIndex = Convert.ToInt32(Console.ReadLine());
                
                Game.Current.Buy(shopIndex, teamIndex);
                break;
            case 2:
                Console.WriteLine(Game.Current.team);
                teamIndex = Convert.ToInt32(Console.ReadLine());
                
                Game.Current.Sell(teamIndex);
                break;
            case 3:
                Console.WriteLine(Game.Current.team);
                Console.WriteLine("Escolha a posição 1º: ");
                teamIndex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escolha a posição 2º: ");
                int teamIndex2 = Convert.ToInt32(Console.ReadLine());

                Game.Current.team.SwitchBoneco(teamIndex, teamIndex2);
                break;
            case 4:

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
    protected int round { get; set; } = 1;
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
    public void Fight()
    {    
        Team enemyTeam = new Team();
        
        if(round == 1)
            enemyTeam.AddRandomBoneco(3);
        else
            enemyTeam.AddRandomBoneco(5);
        
        while(enemyTeam.getSize() > 0 && team.getSize() > 0)
        {
            enemyTeam.GetTeam(-1);

        }

        round++;
    }
}

public void TradeDamage(Boneco boneco1, Boneco boneco2)
{
    
}