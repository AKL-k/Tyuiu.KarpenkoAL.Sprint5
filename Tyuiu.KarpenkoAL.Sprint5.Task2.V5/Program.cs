using Tyuiu.KarpenkoAL.Sprint5.Task2.V5.Lib;

DataService ds = new DataService();
int[,] mas2 = new int[3, 3] { { 9, 6, 6 },
                              { 8, 7, 2 },
                              { 1, 7, 8 }, };

int rows = mas2.GetLength(0);
int columns = mas2.GetLength(1);

Console.Title = "Спринт #5 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значен *");
Console.WriteLine("* иями с клавиатуры. Заменить нечетные элементы массива на 0. Результат с *");
Console.WriteLine("* охранить в файл OutPutFileTask2.csv и вывести на консоль.               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++) 
{
    for (int j = 0; j < columns; j++) 
    {
        Console.Write($"{mas2[i, j]} \t");
    }

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(mas2);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();




