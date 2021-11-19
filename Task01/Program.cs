// Задача 1. Дано число. Проверить, кратно ли оно 7 и 23.

Console.WriteLine("Задача 1. Дано число. Проверить, кратно ли оно 7 и 23.");

int Number = new Random().Next(-1000, 1000);
Console.WriteLine($"Имеется число {Number}");

if ((Number % 7 == 0) && (Number % 23 == 0))
{
    Console.WriteLine("Данное число кратно 7 и 23");
}
else
{
    Console.WriteLine("Данное число не кратно 7 и 23");
}