public class Boneco
{
    public Boneco() {}
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Life { get; set; }
    public int Tier { get; set; } 
    public int Experience { get; set; } = 1;
    public int Level { get; set; }
    public int Position { get; set; }
    public Passive passive { get; set; }

    public string getName() => this.Name;
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
    public int GetLevel() => this.Level;
    public Passive getPassive() => this.passive;
}