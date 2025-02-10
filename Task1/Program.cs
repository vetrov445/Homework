using System;
using System.Numerics;
using System.Threading;

class Program
{
    static void Main()
    {
        //Ініціалізація змінних
        int[] numbers = new int[100];
        Thread[] threads = new Thread[numbers.Length];
        Random random = new Random();

        //Генерація масиву випадкових значень
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        //Створення потоків обчислення значення факторіала
        for (int i = 0; i < numbers.Length; i++)
        {
            threads[i] = new Thread(() => CalculateFactorial(numbers[i]));
            threads[i].Start();
        }

        //Очікування завершення роботи потоків
        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("Розрахунок закінчено.");
    }

    //Функція відловлення переповнення при обчисленні факторіалу
    static void CalculateFactorial(int num)
    {
        try
        {
            BigInteger result = Factorial(num);
            Console.WriteLine($"Факторіал числа: {num}! = {result}");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Факторіал числа: {num}! занадто великий для обчислення.");
        }
    }

    //Функція обчислення факторіалу
    static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
