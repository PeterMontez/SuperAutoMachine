using System;
using System.Collections.Generic;

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