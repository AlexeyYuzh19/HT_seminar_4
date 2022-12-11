/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
Степени с натуральным показателем - это вид степени, показателем которой является натуральное число. 
Натуральными называют целые числа, которые больше нуля.
*/
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello, World!");

int A,B;

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"{A = CheckInputNumber()} - число А");

Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"{B = CheckInputNumber()} - число В");

Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine($"Результат возведения числа {A} (A) в натуральную степень числа {B} (B) равен:  " + A_natural_B(A,B) + "\n");

Console.ResetColor();

int A_natural_B(int num_A, int num_B)
{
    int res = 1;
    for (int i = 1; i <= num_B; i++)
    {
        res *= num_A;
    }
    return res;
}

int CheckInputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите число: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number == 0)
            {
              System.Console.WriteLine("заданное число = 0.");
            }
            if (number < 0)
            {
              System.Console.WriteLine("задано отрицательное число.");
            } 
            if (number > 0)
            {
               break; 
            }               
        }
        Console.WriteLine("заданное значение не удовлетвояет критериям, попробуйте еще раз.");
    }        
    return number;
}