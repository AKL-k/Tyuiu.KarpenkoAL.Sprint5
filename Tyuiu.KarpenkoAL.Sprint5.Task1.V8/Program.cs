using Tyuiu.KarpenkoAL.Sprint5.Task1.V8.Lib;

DataService ds = new DataService();

int startValue = -5;
int stopValue = 5;

Console.Title = "Спринт #5 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция (произвести табулирование) f(x) на заданном диапазоне [-5; *");
Console.WriteLine("* 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль  *");
Console.WriteLine("* вернуть значение 0. результат сохранить в текстовый файл OutPutFileTask *"); 
Console.WriteLine("* 1.txt и вывести на консоль в таблицу. Значения округлить до двух знаков *"); 
Console.WriteLine("* после запятой.                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Начало шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
