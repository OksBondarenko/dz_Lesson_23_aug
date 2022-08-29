//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string[] SplitOnArray(string a)
{
    string[] result = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    return result;
}

int CountPositiveNumbers(string[] num)
{
    int count = 0;

    foreach (string i in num)
    {
        if (Convert.ToInt32(i) > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите числа через пробел: ");
Console.WriteLine($"В введенных числах {CountPositiveNumbers(SplitOnArray(Console.ReadLine()))} положительных значений");