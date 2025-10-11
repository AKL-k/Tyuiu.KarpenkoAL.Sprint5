using Tyuiu.KarpenkoAL.Sprint5.Task5.V7.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С://DataSprint5//InPutDataFileTask5V7.txt (файл взять из архив *");
Console.WriteLine("* а согласно вашему варианту. Создать папку в ручную С://DataSprint5/ и с *");
Console.WriteLine("* копировать в неё файл) в котором есть набор целых значений. Найти факто *");
Console.WriteLine("* риал первого целого числа в файле. Полученный результат вывести на конс *");
Console.WriteLine("* оль. У вещественных значений округлить до трёх знаков после запятой.    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = args.Length > 0 ? args[0] : @"C:\DataSprint5\InPutDataFileTask5V7.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();
