// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
int userNum = ReadInput("Введите целое число: ");

static int CalkDigits(int number)       //Создали функцию подсчёта знаков
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }

    return count;
}

int SumNumber(int number)
{
    int sum = 0;
    int count = CalkDigits(number);
    for (int i = 0; i < count; i++)
    {
        int num = number % 10;
        sum = sum + num;
        number = number / 10;
    }
    return sum;
}

System.Console.WriteLine($"Сумма знаков в числе {userNum} равра {SumNumber(userNum)}.");