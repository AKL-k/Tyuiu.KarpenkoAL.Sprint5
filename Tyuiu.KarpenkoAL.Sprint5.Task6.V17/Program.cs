using Tyuiu.KarpenkoAL.Sprint5.Task6.V17.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С://DataSprint5//InPutDataFileTask6V17.txt (файл взять из архи *");
Console.WriteLine("* ва согласно вашему варианту. Создать папку в ручную С://DataSprint5// и *");
Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Найти ко *");
Console.WriteLine("* личество пробелов, идущих подряд больше одного, в заданной строке.      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = args.Length > 0 ? args[0] : @"C:\DataSprint5\InPutDataFileTask6V17.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();
