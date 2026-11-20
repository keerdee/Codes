using System;

namespace новое
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pcNumber = random.Next(1, 101);
            uint attempts = 0;

            Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

            while (true)
            {
                Console.Write("\nВведи предполагаемое число: ");
                int playerNumber = int.Parse(Console.ReadLine());
                attempts++;

                if (pcNumber == playerNumber)
                {
                    Console.WriteLine($"Ураа, победа! Ты угадал число {pcNumber}!");
                    Console.WriteLine("Число попыток: " + attempts);
                    break;
                }
                else if (playerNumber < pcNumber)
                {
                    Console.WriteLine("Попробуй еще раз! Твое число меньше загаданного.");
                }
                else
                {
                    Console.WriteLine("Попробуй еще раз! Твое число больше загаданного.");
                }
            }

            Console.ReadLine();
        }
    }
}
