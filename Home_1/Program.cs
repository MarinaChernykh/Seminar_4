//Напишите цикл, который принимает
// на вход два числа (A и B) и возводит
//число A в натуральную степень B.

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0) Console.WriteLine("Введенная степень должна быть положительным числом!");
else
{
    Console.WriteLine ($"Результат = {Multi(A, B)}");
}

int Multi(int Base, int Pow)
{
    int result = 1;
    for (int i = 1; i <= Pow; i++)
    {
        result *= Base;
    }
    return result;
}
