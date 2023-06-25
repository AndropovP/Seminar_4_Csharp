// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
int userNumA = ReadInput("Введите первое целое число: ");
int userNumB = ReadInput("Введите второе целое число: ");

int NumDegree(int num1, int num2)
{
    int rez = num1;
    for (int i = 1; i < num2; i++)
    {
        rez = rez * num1;
    }
    return rez;
}

System.Console.WriteLine($"Число {userNumA} в степени {userNumB} равно {NumDegree(userNumA, userNumB)}.");