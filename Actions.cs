public class Actions
{
    public void gainGold(int gold)
    {
        Game.Current.Money += gold;
    }

    public void gainXP(Boneco boneco, int xp)
    {
        boneco.ChangeXp(xp);
    }

    public void ChangeAttack(Boneco boneco, int value)
    {
        boneco.ChangeAttack(value);
    }

    public void ChangeLife(Boneco boneco, int value)
    {
        boneco.ChangeLife(value);
    }

    public virtual void run(int position) {}
}

public class GainGold : Actions 
{
    protected int gold { get; set; }

    public GainGold(int gold)
    {
        this.gold = gold;
    }

    public override void run(int uselessParam)
    {
        Game.Current.Money += gold;
    }
}

public class ChangeLife : Actions 
{
    //public override void run(Boneco boneco, int value)
    public override void run(int position)
    {
        //boneco.ChangeLife(value);
    }
}

public class ChangeAttack : Actions 
{
    //public override void run(Boneco boneco, int value)
    public override void run(int position)
    {
        //boneco.ChangeAttack(value);
        team.GetTeam(position);
    }
}