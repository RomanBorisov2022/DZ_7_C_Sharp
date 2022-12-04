// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int m = UserInput("Введите колличество строк: ", "Ошибка ввода.");
int n = UserInput("Введите колличество столбцов: ", "Ошибка ввода.");
int[,] array = GetArray(m, n);
PrintArray(array);

int coordRow = UserInput("Введите номер строки: ", "Ошибка ввода.");
int coordColomn = UserInput("Введите номер столбца: ", "Ошибка ввода.");
int row = coordRow - 1;
int colomn = coordColomn - 1;
Console.WriteLine($"В данной ячейке число: {array[row, colomn]}");




int UserInput(string message, string errorMessage) //___________________ввод пользователя
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userInput))
            return userInput;

        Console.WriteLine(errorMessage);
    }
}

int[,] GetArray(int m, int n)                       //______получение рандомного массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i, j] = new Random().Next(10, 99);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)                         //_______ вывод массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}