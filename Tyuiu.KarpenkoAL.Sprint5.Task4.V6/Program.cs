using Tyuiu.KarpenkoAL.Sprint5.Task4.V6.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С://DataSprint5//InPutDataFileTask4V0.txt (файл взять из архив *");
Console.WriteLine("* а согласно вашему варианту. Создать папку в ручную С://DataSprint5// и  *");
Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Прочитать *");
Console.WriteLine("* значение из файла и подставить вместо Х в формуле. Вычислить значение п *");
Console.WriteLine("* о формуле (Полученное значение округлить до 3-ёх знаков после запятой)  *");
Console.WriteLine("* и вернуть полученный результат на консоль.                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = args.Length > 0 ? args[0] : @"C:\DataSprint5\InPutDataFileTask4V6.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();
