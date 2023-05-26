using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private List<Boneco> team = new List<Boneco>(5);
    
    public int getSize() => team.Count();
    public void Fusion(int i, int j)
    {
        team[i].ChangeXp(team[j].GetXp());
        team[i].ChangeLife((int)(team[i].GetLife() > team[j].GetLife() ? team[i].GetLife() + 1 : team[j].GetLife() + 1));
        team[i].ChangeAttack(team[i].GetAttack() > team[j].GetAttack() ? team[i].GetAttack() + 1 : team[j].GetAttack() + 1);
    }
    public bool AddBoneco(Boneco boneco)
    {
        if (team.Count() < 5)
        {
            team.Add(boneco);
            return true;
        }
        return false;
    }
    public bool AddRandomBoneco(int quantity)
    {
        Random random = new Random();
        random.Next(0, )

        return false;
    }
    public bool PopBoneco(int index)
    {
        if (team.Count() > 0)
        {
            team.RemoveAt(index);
            return true;
        }
        return false;
    }
    public bool SwitchBoneco(int indexA, int indexB)
    {
        if  (indexA > 5 || indexB > 5 || indexA < 0 || indexB < 0)
            return false;
        var temp = team[indexA];
        team[indexA] = team[indexB];
        team[indexB] = temp;
        return true;
    }
    public Boneco GetTeam(int index) => team[index];
    
    public override string ToString()
    {
        string StringShop = "";

        for (int i = 0; i < team.Count; i++)
        {
            if(team[i] != null)
            {
                StringShop += "[ " + team[i].getName() + " - ";
                StringShop += team[i].GetAttack() + " - ";
                StringShop += team[i].getPassive().Name ?? "Não tem passiva" + " - ";
                StringShop += team[i].GetLife() + "]";
                StringShop += "\n";
            }
        }
 
        return StringShop;
    }
}