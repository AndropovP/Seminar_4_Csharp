// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8

int[] GetRandomArray(int length)                //Функция заполнения массива
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100,200);
    }
    return array;
}

int ReadInt(string message)                        // Проверка на численный формат данных
{
    Console.Write($"{message} ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число!");
    Environment.Exit(0);
    return 0;
}

void ShowArray(int[] arr)                       //Функция вывода массива
{
    foreach (int item in arr)                   
    {
        System.Console.Write($"{item} ");
    }
}

int length = ReadInt("Введите длину массива: ");


int[] arr = GetRandomArray(length);
ShowArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Длина массива составляет -> {arr.Length}.");