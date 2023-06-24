//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// (*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число!");
    Environment.Exit(0);
    return 0;
}

int[] GenerateArray(string message)
{
    System.Console.WriteLine(message);
    int len = Prompt("Введите длину массива:");
    int min = Prompt("Введите минимальный порог случайных значений: ");
    int max = Prompt("Введите максимальный порог случайных значений");
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}
void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + "\t");
    }
}

int[] NewArray = GenerateArray("Ваш массив: ");
PrintArray(NewArray);