using System;

public class Interface
{
    public int Menu()
    {    
        Console.WriteLine($"01 - Comprar.");
        Console.WriteLine($"02 - Vender.");
        Console.WriteLine($"03 - Reposicionar.");
        Console.WriteLine($"04 - Iniciar.");

        return Convert.ToInt32(Console.ReadLine());

    }
    public void Selector(int option)
    {
        switch(option)
        {
            case 1:
                Console.WriteLine(WorkShop.Current);
                int shopIndex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Game.Current.team);
                int teamIndex = Convert.ToInt32(Console.ReadLine());
                
                Game.Current.Buy(shopIndex, teamIndex);
                break;
            case 2:
                Console.WriteLine(Game.Current.team);
                teamIndex = Convert.ToInt32(Console.ReadLine());
                
                Game.Current.Sell(teamIndex);
                break;
            case 3:
                Console.WriteLine(Game.Current.team);
                Console.WriteLine("Escolha a posição 1º: ");
                teamIndex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escolha a posição 2º: ");
                int teamIndex2 = Convert.ToInt32(Console.ReadLine());

                Game.Current.team.SwitchBoneco(teamIndex, teamIndex2);
                break;
            case 4:

                break;
        }
    }
}