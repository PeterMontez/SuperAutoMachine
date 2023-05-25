public abstract class Actions
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

}