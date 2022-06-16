// Напишите программу, которая принимает
// на вход число и выдаёт
//количество цифр в числе

void quantity (string Number)
{
    if (Convert.ToString(Number[0]) == "-")
    {
        int count = Number.Length - 1;
        Console.WriteLine ($"Кол-во цифр = {count}");
    }
    else
    {
        int count = Number.Length;
        Console.WriteLine ($"Кол-во цифр = {count}");  
    }
}

Console.Write("Введите любое число: ");
string Number = Console.ReadLine();

// Проверка на то, что введено число
bool Check = Int32.TryParse (Number, out int Number2);
if (Check == false) Console.WriteLine("Ошибка ввода!");
else
{
    quantity (Number);
}
