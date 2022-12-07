// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int m = UserInput("Введите колличество строк: ", "Ошибка ввода.");
int n = UserInput("Введите колличество столбцов: ", "Ошибка ввода.");
int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);
double[] newArray = GetAverage(array);
Console.Write("Среднее арифметическое каждого столбца равно: ");
Console.WriteLine(String.Join(" ", newArray));



double[] GetAverage(int[,] array)
{
    
    double[] newArray = new double [array.GetLength(1)];
    
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {          
            sum = sum + array[i, j];
            
        }
        newArray[j] = Math.Round(sum / array.GetLength(0), 1);      
    }
    return newArray;    
}


//___________ввод пользователя
int UserInput(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userInput))
            return userInput;

        Console.WriteLine(errorMessage);
    }
}
// __________________заполнение массива
int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
//___________________вывод массива
void PrintArray(int[,] inArray)
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