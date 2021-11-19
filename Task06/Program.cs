// Задача 6. Задать номер четверти, показать диапазоны для возможных координат.

Console.WriteLine("Задача 6. Задать номер четверти, показать диапазоны для возможных координат.");

Console.WriteLine("Напишите число от 1 до 4");

int Quarter = Convert.ToInt16(Console.ReadLine());

if (Quarter < 1 || Quarter > 4)
{
    Console.WriteLine("Вы указали число, не соответствующее требованиям. Попробуйте еще раз.");
}
Console.WriteLine($"Вы выбрали {Quarter} координатную четверть");

switch (Quarter)
{
    case 1:
        Console.WriteLine("Вы можете работать с координатами, располагающимися в диапазоне x>0, y>0");
        break;
    case 2:
        Console.WriteLine("Вы можете работать с координатами, располагающимися в диапазоне x<0, y>0");
        break;
    case 3:
        Console.WriteLine("Вы можете работать с координатами, располагающимися в диапазоне x<0, y<0");
        break;
    case 4:
        Console.WriteLine("Вы можете работать с координатами, располагающимися в диапазоне x>0, y<0");
        break;
    default:
        break;
}
