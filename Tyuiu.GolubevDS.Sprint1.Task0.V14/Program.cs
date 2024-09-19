using Tyuiu.GolubevDS.Sprint1.Task0.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил Голубев Д. С. | ИБКСб-24-1";
Console.WriteLine("**************************************************************************");
Console.WriteLine("* Спринт #1                                                              *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                            *");
Console.WriteLine("* Задание #0                                                             *");
Console.WriteLine("* Вариант #14                                                            *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб-24-1                       *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                               *");
Console.WriteLine("* Написать программу, которая вычисляет выражение 2*3*3+7                *");
Console.WriteLine("* и печатает результат на экране                                         *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* 2*3*3+7                                                                *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                              *");
Console.WriteLine("**************************************************************************");

Console.WriteLine(ds.Calculate());
Console.ReadLine();
