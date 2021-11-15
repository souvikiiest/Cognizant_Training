using System;
public class Game
{
    public string Name {get;set;}
    public int MaxNumPlayers{get;set;}
    
    public override string ToString()
    {
        return("Maximum number of players for "+ Name +" is "+ MaxNumPlayers);
    }
    
}
public class GameWithTimeLimit:Game
{
    public int TimeLimit{get;set;}
    
    public override string ToString()
    {
        Console.WriteLine(base.ToString());
        return("Time Limit for "+Name+" is "+TimeLimit+" minutes");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Game gm=new Game();
        GameWithTimeLimit gmtlm=new GameWithTimeLimit();
        
        Console.WriteLine("Enter a game");
        gm.Name=Console.ReadLine();
        
        Console.WriteLine("Enter the maximum number of players");
        gmtlm.MaxNumPlayers=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter a game that has time limit");
        gmtlm.Name=Console.ReadLine();
        
        //Console.WriteLine("Enter the maximum number of players");
        //gmtlm.MaxNumPLayers=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the time limit in minutes");
        gmtlm.TimeLimit=int.Parse(Console.ReadLine());
        
        Console.WriteLine(gm.ToString());
        Console.WriteLine(gmtlm.ToString());
    }
}
