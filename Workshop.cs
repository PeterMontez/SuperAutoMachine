using System.Collections.Generic;

public class WorkShop
{
    private WorkShop() {}
    private static WorkShop crr = null;
    public static WorkShop Current => crr;
    public Maternity AllBonecos = new Maternity();
    protected List<Boneco> ShopBonecos = new List<Boneco>();
    public Boneco GetBoneco(int index) => ShopBonecos[index]; 
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