// Напишите программу, которая принимает на вход
// число А и выдает сумму чисел от 1 до А


void Summ(int A)
{
    int result = 0;
    for (int i = 1; i <= A; i++)
    {
        result = result + i;
    }
    Console.WriteLine($"Сумма чисел = {result}");
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Summ(A);
