using System;
using System.Threading;
public class Stuff
{
    public static (int, int) fight1(int player1, int player2, string name1, string name2)
    {

        Random generator = new Random();
        int punchDmg = generator.Next(5, 16);
        int kickDmg = generator.Next(25, 51);


        string answer = "";
        answer = answer.ToLower();
        while (answer != "punch" && answer != "kick" && answer != "slap")
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{name1} punch or kick or slap?");
            answer = Console.ReadLine();

        }
        if (answer == "punch")
        {
            int crit = generator.Next(100);
            if (crit < 15)
            {
                player2 = player2 - 75;
                Console.WriteLine($"{name1} did 75 damage");
                Console.WriteLine($"{name2} has {player2}hp left");
                Console.WriteLine();
            }
            else
            {
                player2 = player2 - punchDmg;
                Console.WriteLine($"{name1} did {punchDmg} damage");
                Console.WriteLine($"{name2} has {player2}hp left");
                Console.WriteLine();
            }
        }
        if (answer == "kick")
        {
            player2 = player2 - kickDmg;
            Console.WriteLine($"{name1} did {kickDmg} damage");
            Console.WriteLine($"{name2} has {player2}hp left");
            Console.WriteLine();
        }
        if (answer == "slap")
        {
            int crit = generator.Next(100);
            if (crit < 15)
            {
                player2 = player2 - 130;
                Console.WriteLine($"{name1} did 130 damage");
                Console.WriteLine($"{name2} has {player2}hp left");
                Console.WriteLine();
            }
            else
            {
                player1 = player1 - 25;
                Console.WriteLine($"{name2} did 25 damage to you");
                Console.WriteLine($"{name1} has {player1}hp left");
                Console.WriteLine();
            }
        }

        if (player1 > 0 && player1 <= 10)
        {
            int instaKill = generator.Next(2);

            Thread.Sleep(1000);
            Console.WriteLine($"There is a 50% chance to kill instakill your opponent");
            Thread.Sleep(2500);

            if (instaKill == 0)
            {
                Console.WriteLine($"Lucky one you instakilled");
                player1 = player1 - player1;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Unlucky you lost");
                Console.ReadLine();
            }
        }
            if (player2 > 0 && player2 <= 10)
        {
            int instaKill = generator.Next(2);

            Thread.Sleep(1000);
            Console.WriteLine($"There is a 50% chance to kill instakill your opponent");
            Thread.Sleep(2500);

            if (instaKill == 0)
            {
                Console.WriteLine($"Lucky one you instakilled");
                player2 = player2 - player2;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Unlucky you lost");
                Console.ReadLine();
            }
        }
        return (player1, player2);
    }


    public static (int, int) fight2(int player2, int player1, string name1, string name2)
    {
        Random generator = new Random();
        int punchDmg = generator.Next(5, 16);
        int kickDmg = generator.Next(25, 51);

        string answer = "";
        answer = answer.ToLower();

        while (answer != "punch" && answer != "kick" && answer != "slap")
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{name2} punch or kick or slap?");
            answer = Console.ReadLine();
        }
        if (answer == "punch")
        {
            int crit = generator.Next(100);

            if (crit < 15)
            {
                player1 = player1 - 75;
                Console.WriteLine($"{name2} did 75 damage");
                Console.WriteLine($"{name1} has {player1}hp left");
                Console.WriteLine();
            }
            else
            {
                player1 = player1 - punchDmg;
                Console.WriteLine($"{name2} did {punchDmg} damage");
                Console.WriteLine($"{name1} has {player1}hp left");
                Console.WriteLine();
            }

        }
        if (answer == "kick")
        {
            player1 = player1 - kickDmg;
            Console.WriteLine($"{name2} did {kickDmg} damage");
            Console.WriteLine($"{name1} has {player1}hp left");
            Console.WriteLine();
        }
        if (answer == "slap")
        {
            int crit = generator.Next(100);

            if (crit < 15)
            {
                player1 = player1 - 130;
                Console.WriteLine($"{name2} did 130 damage");
                Console.WriteLine($"{name1} has {player1}hp left");
                Console.WriteLine();
            }
            else
            {
                player2 = player2 - 25;
                Console.WriteLine($"{name1} did 25 damage to you");
                Console.WriteLine($"{name2} has {player2}hp left");
                Console.WriteLine();
            }
        }

        if (player2 > 0 && player2 <= 10)
        {
            int instaKill = generator.Next(2);

            Thread.Sleep(1000);
            Console.WriteLine($"There is a 50% chance to kill instakill your opponent");
            Thread.Sleep(2500);

            if (instaKill == 0)
            {
                Console.WriteLine($"Lucky one you instakilled");
                player2 = player2 - player2;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Unlucky you lost");
                Console.ReadLine();
            }
        }
        if (player1 > 0 && player1 <= 10)
        {
            int instaKill = generator.Next(2);

            Thread.Sleep(1000);
            Console.WriteLine($"There is a 50% chance to kill instakill your opponent");
            Thread.Sleep(2500);

            if (instaKill == 0)
            {
                Console.WriteLine($"Lucky one you instakilled");
                player1 = player1 - player1;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Unlucky you lost");
                Console.ReadLine();
            }
        }
        return (player2, player1);
    }
}