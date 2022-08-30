/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */

double b1 = ReadDouble("Введите b1: ");
double k1 = ReadDouble("Введите k1: ");
double b2 = ReadDouble("Введите b2: ");
double k2 = ReadDouble("Введите k2: ");

double [] Coordinates(double b1, double k1, double b2, double k2)
{
    double [] result = new double [2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
}

double ReadDouble(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}
if (b1 == b2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые совпадают"); 
    }

    else
    {
        Console.WriteLine("Прямые не пересекаются"); 
    }
}
else
{
    double [] arr = Coordinates(b1, k1, b2, k2);
    Console.WriteLine($"Координата x {arr[0]} \nКоордината y {arr[1]}");
}