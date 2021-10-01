using System;
using System.Threading;
public class Stuff
{
    public static void fight1()
    {   
        int P1hp = 100;
        int P2hp = 100;

        Random generator = new Random();
        int x = generator.Next(5, 11);
        int y = generator.Next(10, 21);

        string answer = "";
        answer = answer.ToLower();
        while (answer != "punch" && answer != "kick")
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Player 1 punch or kick?");
            answer = Console.ReadLine();
            
        }
        if (answer == "punch")
        {
            P2hp = P2hp - x;
            Console.WriteLine($"Player 2 has {P2hp}hp left");
        }
        if (answer == "kick")
        {
            P2hp = P2hp - y;
            Console.WriteLine($"Player 2 has {P2hp}hp left");
        }
    }
    public static void fight2()
    {
        int P1hp = 100;
        int P2hp = 100;

        Random generator = new Random();
        int x = generator.Next(5, 11);
        int y = generator.Next(10, 21);

        string answer = "";
        answer = answer.ToLower();

        while (answer != "punch" && answer != "kick")
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Player 2 punch or kick?");
            answer = Console.ReadLine();
        }
        if (answer == "punch")
        {
            P1hp = P1hp - x;
            Console.WriteLine($"Player 1 has {P1hp}hp left");
        }
        if (answer == "kick")
        {
            P1hp = P1hp - y;
            Console.WriteLine($"Player 1 has {P1hp}hp left");
        }
    }
}