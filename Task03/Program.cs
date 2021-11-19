// Задача 3. По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Задача 3. По двум заданным числам проверять, является ли одно квадратом другого.");

Console.WriteLine("Введите число А: ");
int NumbA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int NumbB = Convert.ToInt32(Console.ReadLine());

if (NumbA == NumbB * NumbB)
{
    Console.WriteLine($"Число {NumbA} является квадратом числа {NumbB}");
}
else if (NumbB == NumbA * NumbA)
{
    Console.WriteLine($"Число {NumbB} является квадратом числа {NumbA}");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого.");
}