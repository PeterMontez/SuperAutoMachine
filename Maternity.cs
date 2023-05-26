public class Maternity
{
    private Boneco piece;
    
    public Maternity()
    {
        piece = new Boneco();
    }

    public Maternity Nome (string name)
    {
        piece.Name = name;
        return this;
    }

    public Maternity Life (int life)
    {
        piece.Life = life;
        return this;
    }

    public Maternity Attack (int attack)
    {
        piece.Damage = attack;
        return this;
    }

    public Maternity Tier (int tier)
    {
        piece.Tier = tier;
        return this;
    }

    public Maternity Experience (int xp)
    {
        piece.Experience = xp;
        return this;
    }

    public Maternity Level (int level)
    {
        piece.Level = level;
        return this;
    }

    public Maternity Passive (Passive passive)
    {
        piece.passive = passive;
        return this;
    }

    public Boneco birth()
    {
        return piece;
    }
}

public class BuildBoneco
{
    public int round { get; set; }
    public Maternity mat = new Maternity();
    public int position { get; set; }

    public BuildBoneco(int round)
    {
        this.round = round;
    }

    public Boneco Martelo() =>  mat.Attack(2).Life(3).Level(1).Tier(1).Experience(1).Nome("Martelo").birth();
    public Boneco ChaveDeFenda() =>  mat.Attack(2).Life(3).Level(1).Tier(1).Experience(1).Nome("Chave de Fenda").birth();
    public Boneco Esteira() =>  mat.Attack(3).Life(1).Level(1).Tier(1).Experience(1).Nome("Esteira").Passive(new Sold(position, new GainGold(1))).birth();
    public Boneco Furadeira() =>  mat.Attack(2).Life(1).Level(1).Tier(1).Experience(1).Nome("Furadeira").birth();

    public Boneco FuradeiraDeColuna() =>  mat.Attack(3).Life(5).Level(1).Tier(2).Experience(1).Nome("Furadeira de Coluna").birth();
    public Boneco FornoIndustrialAGas() =>  mat.Attack(1).Life(3).Level(1).Tier(2).Experience(1).Nome("Forno Industrial á Gás").birth();
    public Boneco RetificaPlana() =>  mat.Attack(4).Life(2).Level(1).Tier(2).Experience(1).Nome("Retífica Plana").birth();

    public Boneco FuradeiraDeCoordenada() =>  mat.Attack(3).Life(5).Level(1).Tier(3).Experience(1).Nome("Furadeira de Coordenada").birth();
    public Boneco FornoIndustrialEletrico() =>  mat.Attack(4).Life(3).Level(1).Tier(3).Experience(1).Nome("Forno Industrial Elétrico").birth();
    public Boneco RetificaCilindrica() =>  mat.Attack(2).Life(6).Level(1).Tier(3).Experience(1).Nome("Retífica Cilindrica").birth();
    public Boneco JetCutting() =>  mat.Attack(6).Life(3).Level(1).Tier(3).Experience(1).Nome("Jet Cutting").birth();

    public Boneco Fresa() =>  mat.Attack(4).Life(5).Level(1).Tier(4).Experience(1).Nome("Fresa").birth();
    public Boneco Torno() =>  mat.Attack(5).Life(3).Level(1).Tier(4).Experience(1).Nome("Torno").birth();

    public Boneco TornoCNC() =>  mat.Attack(5).Life(8).Level(1).Tier(5).Experience(1).Nome("Torno CNC").birth();
    public Boneco FresaCNC() =>  mat.Attack(8).Life(4).Level(1).Tier(5).Experience(1).Nome("Fresa CNC").birth();

    public Boneco CorteAPlasmaCNC() =>  mat.Attack(6).Life(8).Level(1).Tier(6).Experience(1).Nome("Corte a Plasma CNC").birth();

}
