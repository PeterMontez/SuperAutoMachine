using System.Collections.Generic;

public class WorkShop
{
    private WorkShop() {}
    private static WorkShop crr = null;
    public static WorkShop Current => crr;
    public Maternity AllBonecos = new Maternity();

    protected List<Boneco> ShopBonecos = new List<Boneco>();

    public void RefreshShop()
    {
        ShopBonecos.Clear();

        for (int i = 0; i < 3; i++)
        {
            ShopBonecos.Add(Maternity.New());
        }
    }
    
    public Boneco? SellBoneco(int index) 
    {
        if(ShopBonecos[index] != null)
        {
            Boneco boneco = ShopBonecos[index]; 
            ShopBonecos.RemoveAt(index);
            return boneco;
        }
        return null;
    }
}
public class Game
{
    private Game() {}
    private static Game crr = null;
    public static Game Current => crr;
    public int Money { get; set; } = 10;
    protected Team team = new Team();
    protected int round { get; set; }
    public void Buy(int index)
    {
        if(this.Money >= 3 && WorkShop.Current.SellBoneco(index) != null) 
        { 
            this.Money -= 3;
            team.AddBoneco(WorkShop.Current.SellBoneco(index));
        }
    }


}