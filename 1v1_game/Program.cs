using System;
using System.Threading;
{

}

int P1hp = 350;
int P2hp = 350;
string name1;
string name2;

name1 = "";
name2 = "";

Random generator = new Random();


Console.WriteLine($"Player 1 write your name");
name1 = Console.ReadLine();

Console.WriteLine($"Player 2 write your name");
name2 = Console.ReadLine();
Console.WriteLine();

Thread.Sleep(1000);
Console.WriteLine($"{name1} has {P1hp}hp");
Thread.Sleep(1000);
Console.WriteLine($"{name2} has {P2hp}hp");
Thread.Sleep(1000);
Console.WriteLine();

int r = generator.Next(2);

if (r == 0)
{
    Console.WriteLine($"{name1} start");

    while (P1hp >= 0 && P2hp >= 0)
    {
        (int p1, int p2) result1 = Stuff.fight1(P2hp, P1hp, name1, name2);
        P2hp = result1.p1;
        P1hp = result1.p2;
        
        (int p2, int p1) result2 = Stuff.fight2(P1hp, P2hp, name1, name2);
        P1hp = result2.p2;
        P2hp = result2.p1;
    }

}

if (r == 1)
{
    Console.WriteLine($"{name2} start");

    while (P1hp >= 0 && P2hp >= 0)
    {
        (int p2, int p1) result2 = Stuff.fight2(P1hp, P2hp, name1, name2);
        P1hp = result2.p2;
        P2hp = result2.p1;

         (int p1, int p2) result1 = Stuff.fight1(P2hp, P1hp, name1, name2);
        P2hp = result1.p1;
        P1hp = result1.p2;

    }


}

Console.ReadLine();

