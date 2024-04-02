namespace ConsoleApp5;

public class Program4
{
    
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе целое число:");
        int second = int.Parse(Console.ReadLine());
        TwoIntegers numbers = new TwoIntegers();
        numbers.PrintIntegers();
        Console.WriteLine("Сумма чисел: " + numbers.SumIntegers());
        Console.WriteLine("Наибольшее число: " + numbers.MaxInteger());
        Console.WriteLine("Введите новое значение первого числа:");
        int newFirst = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите новое значение второго числа:");
        int newSecond = int.Parse(Console.ReadLine());
        numbers.ChangeIntegers(newFirst, newSecond);
        numbers.PrintIntegers();
        Console.WriteLine("Сумма чисел: " + numbers.SumIntegers());
        Console.WriteLine("Наибольшее число: " + numbers.MaxInteger());
    }
}