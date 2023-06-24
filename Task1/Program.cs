//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)                                  //функция считыает 
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int NumDegree(int number, int degree)
{
    int result = number;
    for (int i = 1; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}

int num = Prompt("Введите число: ");
int degree = Prompt("Введите степень: ");

int result = NumDegree(num, degree);
System.Console.Write(result);