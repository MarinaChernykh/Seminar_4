// Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

void Sum(int Number)
{
    int sum = 0;
    while (Number != 0)
    {
        sum = sum + Number % 10;
        Number = Number / 10;
    }
    Console.WriteLine($"Сумма цифр числа = {sum}");
}
Sum(Number);
