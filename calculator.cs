using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("Введите знак действия (+, -, *, /):");
        string sign = Console.ReadLine();
        Console.WriteLine("Вы выбрали: " + sign);
        
        Console.WriteLine("Введите первое число!");
        double firstValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Вы выбрали: " + firstValue);
        
        Console.WriteLine("Введите второе число!");
        double secondValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Вы выбрали: " + secondValue);
       
        double result = 0; 

        switch (sign)
        {
            case "-":
                result = firstValue - secondValue;
                break;
            case "+":
                result = firstValue  + secondValue;
                break;
            case "*":
                result = firstValue  * secondValue;
                break;
            case "/":
                if (secondValue == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return;
                }
                result = firstValue  / secondValue;
                break;
            default:
                Console.WriteLine("Неизвестный знак действия!");
                return;
            }
        
        Console.WriteLine("Результат: " + result);
    }
}