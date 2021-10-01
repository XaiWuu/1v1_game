using System;
using System.Threading;
{
     
}

int P1hp = 100;
int P2hp = 100;


Random generator = new Random();

Console.WriteLine($"Player 1 have {P1hp}hp");
Thread.Sleep(1000);
Console.WriteLine($"PLayer 2 have {P2hp}hp");
Thread.Sleep(1000);
int r = generator.Next(2);


if (r == 0)
{
    Console.WriteLine($"Player 1 start");

while (P1hp >= 0 && P2hp >= 0)
{
    Stuff.fight1();
    Stuff.fight2();
}
}

if (r == 1)
{
    Console.WriteLine($"Player 2 start");

    while (P1hp >= 0 && P2hp >= 0)
{
    Stuff.fight2();
    Stuff.fight1();
}
}

Console.ReadLine();
