double X(double k1, double k2, double b1, double b2)
{
    return (b2-b1) / (k1-k2);
}

double Y(double x, double k1, double b1)
{
    return k1 * x + b1;
}

double inputDouble(string promt)
{
    System.Console.Write(promt);
    return Convert.ToDouble(Console.ReadLine());
}

bool ValidateLines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        System.Console.WriteLine("Прямые совпадают");
        else
        System.Console.WriteLine("Прямые пареллельны");
        return false;
    }
    return true;
}

System.Console.WriteLine("Для уравнения y=k*x+b");
double k1 = inputDouble("Введите k1: ");
double b1 = inputDouble("Введите b1: ");
double k2 = inputDouble("Введите k2: ");
double b2 = inputDouble("Введите b2: ");
if (ValidateLines(k1, b1, k2, b2))
{
    double x = X(k1, k2, b1, b2);
    double y = Y(x, k1, b1);
    System.Console.WriteLine($"Для уравнений y={k1}*x+{b1} и y={k2}*x+{b2}");
    System.Console.WriteLine($"Общая точка имеет координаты ({x}; {y})");
}