public class Boneco
{
    private Boneco() {}
    protected string Name { get; set; }
    protected int Damage { get; set; }
    protected int Life { get; set; }
    protected int Tier { get; set; } 
    protected int Experience { get; set; } = 1;
    protected int Level { get; set; }
    protected int Position { get; set; }
    protected Passive passive { get; set; }
    public void ChangeLife(int life) => this.Life += life;
    public void ChangeAttack(int attack) => this.Damage += attack;
    public void ChangeXp(int xp) 
    {
        this.Experience = (int)(this.Experience + xp >= 6 ? 6 : this.Experience + xp);
        
        this.Level = (int)((this.Experience % 3) + 1);
    }
    public int GetXp() => this.Experience;
    public int GetLife() => this.Life;
    public int GetAttack() => this.Damage;
}