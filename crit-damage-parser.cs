using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCrit = 0;
            int damage = int.Parse(Console.ReadLine());

            while (damage != 0)
            {
                // Фильтруем крит сразу при получении урона
                if (damage > 50 && damage % 5 == 0 && damage > maxCrit)
                {
                    maxCrit = damage;
                }

                // Обязательно считываем следующий удар, чтобы не уйти в бесконечный цикл
                damage = int.Parse(Console.ReadLine());
            }

            if (maxCrit > 0)
                Console.WriteLine(maxCrit);
            else
                Console.WriteLine("NO CRIT");
        }
    }
}