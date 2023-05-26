using System;
using System.Collections.Generic;

public class PassiveList
{
    public int value { get; set; }
    public List<Passive> passives { get; set; } = new List<Passive>();

    public void addPassive(Passive addedPassive)
    {
        this.passives.Add(addedPassive);
    }

    public void removePassive(Passive removedPassive)
    {
        this.passives.Remove(removedPassive);
    }
}

public abstract class SoldActions : PassiveList
{
    
}

public abstract class StartOfTurnActions : PassiveList
{

}

public abstract class HurtActions : PassiveList
{
    
}

public abstract class BeforeAttackActions : PassiveList
{
    
}

public abstract class EndOfTurnActions : PassiveList
{
    
}

public class Passive
{
    protected Actions effect { get; set; }
    protected int Position { get; set; }

    public virtual void act() 
    {
        this.effect.run(Position);
    }
}

public class Sold : Passive
{
    public Sold(int position, Actions effect)
    {
        this.Position = position;
        this.effect = effect;
    }
}

public class StartOfTurn : Passive
{
    public StartOfTurn(int position, Actions effect)
    {
        this.Position = position;
        this.effect = effect;
    }
}

public class Hurt : Passive
{
    public Hurt(int position, Actions effect)
    {
        this.Position = position;
        this.effect = effect;
    }
}

public class BeforeAttack : Passive
{
    public BeforeAttack(int position, Actions effect)
    {
        this.Position = position;
        this.effect = effect;
    }
}

public class EndOfTurn : Passive
{
    public EndOfTurn(int position, Actions effect)
    {
        this.Position = position;
        this.effect = effect;
    }
}
