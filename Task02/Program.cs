// Задача 2. Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным

Console.WriteLine("Задача 2. Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным.");
Console.WriteLine();

int Numb = new Random().Next(1, 7);
Console.WriteLine($"Дано число: {Numb}");

switch (Numb)
{
    case 1:
        Console.WriteLine("Это первый день недели - понедельник. Он рабочий.");
        break;
    case 2:
        Console.WriteLine("Это второй день недели- вторник. Он рабочий.");
        break;
    case 3:
        Console.WriteLine("Это третий день недели - среда. Он рабочий.");
        break;
    case 4:
        Console.WriteLine("Это четвертый день недели - четверг. Он рабочий.");
        break;
    case 5:
        Console.WriteLine("Это пятый день недели- пятница. Он рабочий.");
        break;
    case 6:
        Console.WriteLine("Это шестой день недели - суббота: выходной");
        break;
    case 7:
        Console.WriteLine("Это седьмой день недели -воскресенье: выходной");
        break;
    default:
        Console.WriteLine("Вы ввели число, не соответствующее диапазону от 1 до 7");
        break;
}

