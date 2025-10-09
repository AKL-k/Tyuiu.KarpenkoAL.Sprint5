using Tyuiu.KarpenkoAL.Sprint5.Task3.V20.Lib;

DataService ds = new DataService();

int x = 3;

Console.Title = "Спринт #5 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до тр *");
Console.WriteLine("* ёх знаков после запятой.                                                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("x = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();



