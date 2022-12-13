/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Вариант первый написания кода задания массива по задаче.\n");

Console.ForegroundColor = ConsoleColor.Green;

System.Console.WriteLine("Зададим массив из 8 элементов. \n");
int Max = CheckInputNumber("Введите допустимое значение элемента массива: ");

int[] arr = Auto(Max);
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine("[ " + string.Join(" , ", arr) + " ] \n");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Вариант второй написания кода задания массива по задаче.\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите массив из 8 чисел: ");
Console.ForegroundColor = ConsoleColor.Blue;

int i;
int[] a = new int[8];
for (i = 0; i < 8; i++)
{
a[i] = CheckInputNumber("Введите элемент массива: ");
}
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine("Из введенных элементов составлен массив:\n[ " + string.Join(" , ", a) + " ]");
Console.ResetColor();

int[] Auto(int M)
{
    int A,B;

    if (M >= 0) 
    {
      A = 0; B = M;
    }
    else 
    {
      A = M; B = 0;
    }
    
    int[] arr = new int[8];
    Random rand = new Random();
    for (int i = 0; i < 8; i++)
    {
        arr[i] = rand.Next(A, B);
    }
    return arr;
}

int CheckInputNumber(string Text)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(Text);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Заданное значение числа не соответствует критерию, попробуйте еще раз.");
    }
    return number;
}


/*   Вариант введения массива в одну строку, но в диапазоне от 0 до 9

int i;
int[] a = new int[8];
Console.WriteLine("Введите массив чисел: ");
for (i = 0; i < 8; i++)
{
a[i] = Console.ReadKey().KeyChar - '0';
Console.Write(", ");
}
System.Console.WriteLine("\n[ " + string.Join(" , ", a) + " ]");
*/

/*  Вариант введения массива в одну строку с разделением значений запятой:

int[] ar = Console.ReadLine().Split(new char[]{','}, 
StringSplitOptions.RemoveEmptyEntries).Select(i=>int.Parse(i)).ToArray<int>();
System.Console.WriteLine("\n[ " + string.Join(" , ", ar) + " ]");
*/
