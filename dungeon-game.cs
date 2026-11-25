using System;
using System.Threading;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.Write("Введи имя бойца: ");
            player.Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(player.Name))
                player.Name = "Безымянный";

            Random rng = new Random();
            int killedEnemies = 0;

            Console.WriteLine($"Боец {player.Name} входит в данж! HP: {player.Hp}, Урон: {player.Damage}");

            while (player.Hp > 0 && killedEnemies < 5)
            {
                int enemyHp = 40;
                int enemyDamage = 10;

                Console.WriteLine($"\n--- Враг #{killedEnemies + 1} (HP: {enemyHp}, Урон: {enemyDamage}) ---");
                Console.WriteLine("Что выберешь? Впиши: 1 - пойти в бой / 2 - открыть проклятый сундук");
                string playerChoice = Console.ReadLine();

                if (playerChoice == "2")
                {
                    player.OpenCursedChest(rng);
                }
                else if (playerChoice != "1")
                {
                    Console.WriteLine("Неверная команда, выбери 1 или 2!");
                    continue;
                }

                if (player.Hp > 0)
                {
                    Console.WriteLine("Начинается бой!");
                    while (player.Hp > 0 && enemyHp > 0)
                    {
                        enemyHp -= player.Damage;
                        if (enemyHp < 0) enemyHp = 0;

                        if (enemyHp > 0)
                        {
                            player.TakeDamage(enemyDamage);
                        }
                        Console.WriteLine($"Твое здоровье: {player.Hp} | Здоровье врага: {enemyHp}");
                        Thread.Sleep(2000);
                    }

                    if (player.Hp > 0)
                    {
                        killedEnemies++;
                        if (player.CurseCount > 0)
                        {
                            player.CurseCount--;
                            if (player.CurseCount == 0)
                                Console.WriteLine("Проклятие снято!");
                            else
                                Console.WriteLine($"Проклятие ослабло! Осталось убить врагов: {player.CurseCount}");
                        }
                    }
                }
            }

            if (player.Hp <= 0)
            {
                Console.WriteLine("\nВы проиграли!");
            }
            else if (killedEnemies >= 5)
            {
                Console.WriteLine("\nВы выиграли! Данж зачищен.");
            }
        }
    }

    class Player
    {
        public string Name = "";
        public int Hp = 100;
        public int Damage = 15;
        public int CurseCount = 0;

        public void TakeDamage(int amount)
        {
            if (CurseCount > 0)
            {
                Hp = 0;
                Console.WriteLine("Смерть от проклятья!");
            }
            else
            {
                Hp -= amount;
                if (Hp < 0) Hp = 0;
                Console.WriteLine($"Получено {amount} урона. Осталось HP: {Hp}");
            }
        }

        public void OpenCursedChest(Random rng)
        {
            Damage += 25;
            CurseCount = 3;
            int buffOrDebuff = rng.Next(0, 2);

            if (buffOrDebuff == 0)
            {
                Hp += 20;
                Console.WriteLine($"Сундук благословил! +20 HP (теперь {Hp}), урон: {Damage}, проклятие: {CurseCount}");
            }
            else
            {
                Hp -= 15;
                if (Hp < 0) Hp = 0;
                Console.WriteLine($"Ловушка в сундуке! -15 HP (осталось {Hp}), урон: {Damage}, проклятие: {CurseCount}");
            }
        }
    }
}
