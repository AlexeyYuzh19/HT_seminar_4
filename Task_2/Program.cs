/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Hello, World!");

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello, World!");

Console.ForegroundColor = ConsoleColor.Green;

int A = CheckInputNumber();

Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine($"Сумма цифр в числе {A} равна:  " + Summa_A(A) + "\n");

Console.ResetColor();

int Summa_A(int num_A)
{
    int res = 0;
    int num_A1 = Math.Abs(num_A); 
        
    string num = num_A1.ToString();
    int[] n = new int[num.Length];
    for( int i=0; i < num.Length; i++)
    {
       n[i] = int.Parse(num[i].ToString());
       res += n[i];
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
           break;
        }
        Console.WriteLine("Заданное значение не является целым числом, попробуйте еще раз.");
    }
    return number;
}