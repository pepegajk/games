using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите программу:");
        Console.WriteLine("1. Игра 'Угадай число'");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                GuessNumberGame();
                break;
            case 2:
                MultiplicationTable();
                break;
            case 3:
                PrintDivisors();
                break;
            default:
                Console.WriteLine("Некорректный выбор программы");
                break;
        }

        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть программу...");
        Console.ReadKey();
    }

    static void GuessNumberGame()
    {
        Random random = new Random();
        int targetNumber = random.Next(0, 101);
        int guess;

        do
        {
            Console.Write("Введите число: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < targetNumber)
            {
                Console.WriteLine("Загаданное число больше");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Загаданное число меньше");
            }
            else
            {
                Console.WriteLine("Поздравляю, вы угадали число!");
            }
        } while (guess != targetNumber);
    }

    static void MultiplicationTable()
    {
        int[,] table = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                table[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Таблица умножения:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0}\t", table[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void PrintDivisors()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Делители числа {0}:", number);

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}