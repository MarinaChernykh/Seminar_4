// Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите в массив {i + 1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("А вот и наш массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
