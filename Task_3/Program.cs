// Напишите программу, которая принимае
// на вход число N и выдаёт произведение
// чисел от 1 до N.

void Multi(int N)
{
    if (N > 0)
    {
        int result = 1;
        for (int i = 1; i <= N; i++)
        {
            result = result * i;
        }
        Console.WriteLine($"Произведение чисел = {result}");
    }
    else Console.WriteLine($"Произведение чисел = 0");
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Multi(N);