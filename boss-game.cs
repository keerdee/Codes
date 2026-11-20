using System;
using System.Threading;

namespace Task;

class Program
{
    static void Main(string[] args)
    {
        int hpPlayer = 100;
        int hpBoss = 100;
        Random random = new Random();

        while (hpBoss > 0 && hpPlayer > 0)
        {
            Console.WriteLine("Твое здоровье: " + hpPlayer);
            Console.WriteLine("Здоровье босса: " + hpBoss);
            Console.WriteLine("Каков твой ход? 1 - удар / 2 - выпить зелье лечения");

            int playerTurn = int.Parse(Console.ReadLine());

            if (playerTurn == 1)
            {
                int forceOfAttack = random.Next(12, 25);
                hpBoss -= forceOfAttack;
                if (hpBoss < 0)
                {
                    hpBoss = 0;
                }
                Console.WriteLine("Ты нанес боссу " + forceOfAttack + " урона!");
            }
            else if (playerTurn == 2)
            {
                hpPlayer += 22;
                if (hpPlayer > 100)
                {
                    hpPlayer = 100;
                }
                Console.WriteLine("Ты выпил зелье! Твое здоровье: " + hpPlayer);
            }
            else
            {
                Console.WriteLine("Неизвестный ход..");
            }

            if (hpBoss > 0)
            {
                int forceOfBossAttack = random.Next(10, 26);
                hpPlayer -= forceOfBossAttack;
                if (hpPlayer < 0)
                {
                    hpPlayer = 0;
                }
                Console.WriteLine("Босс атаковал тебя на " + forceOfBossAttack + " урона!");
            }

            Console.WriteLine("------------------------------------");
            Thread.Sleep(2000);
            Console.Clear();
        }

        if (hpBoss <= 0)
        {
            Console.WriteLine("Ты победил!");
        }
        else
        {
            Console.WriteLine("Ты проиграл!");
        }
    }
}
