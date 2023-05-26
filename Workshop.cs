using System.Collections.Generic;

public class WorkShop
{
    private WorkShop() {}
    private static WorkShop crr = null;
    public static WorkShop Current => crr;
    //public Maternity AllBonecos = new Maternity();            -- MATERNITY É STATIC
    protected List<Boneco> ShopBonecos = new List<Boneco>();
    public Boneco GetBoneco(int index) => ShopBonecos[index]; 
    public void RefreshShop()
    {
        ShopBonecos.Clear();

        for (int i = 0; i < 3; i++)
        {
            ShopBonecos.Add(Maternity.birth(/* Adicionar o parametro "round atual", formato int */));
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