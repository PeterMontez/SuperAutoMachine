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

public class Passive
{
    protected int Position { get; set; }

    public virtual void act() {}
}

public class Sold : Passive
{
    public Sold(int position)
    {
        this.Position = position;
    }

}