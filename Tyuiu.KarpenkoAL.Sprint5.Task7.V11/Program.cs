using Tyuiu.KarpenkoAL.Sprint5.Task7.V11.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С://DataSprint5//InPutDataFileTask7V11.txt (файл взять из архи *");
Console.WriteLine("* ва согласно вашему варианту. Создать папку в ручную С://DataSprint5// и *");
Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных. Удалить *");
Console.WriteLine("* все строчные русские буквы из файла. Полученный результат сохранить в ф *"); 
Console.WriteLine("* айл OutPutDataFileTask7V11.txt.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = args.Length > 0 ? args[0] : @"C:\DataSprint5\InPutDataFileTask7V11.txt";
string pathSaveFile = Path.GetTempFileName();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Находится в файле: ");

pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine(pathSaveFile);
Console.ReadKey();
