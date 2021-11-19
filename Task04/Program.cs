// Задача 4. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.WriteLine("Задача 4. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");
Console.WriteLine();

bool BooleanExpr1(bool x, bool y)
{
    bool result = !(x || y);
    return result;
}

bool BooleanExpr2(bool x, bool y)
{
    bool result = !x && !y;
    return result;
}

void ComparePrintResult(bool x, bool y)
{
    Console.WriteLine($"При значении X = {x} и Y = {y}");
    if (BooleanExpr1(x, y) == BooleanExpr2(x, y))
    {
        Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y истинно");
    }
    else
    {
        Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ложно");
    }
    Console.WriteLine();
}

ComparePrintResult(false, false);
ComparePrintResult(true, false);
ComparePrintResult(false, true);
ComparePrintResult(true, true);



