using Tyuiu.GolubevDS.Sprint1.Task1.V19.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил Голубев Д. С. | ИБКСб-24-1";
Console.WriteLine("**************************************************************************");
Console.WriteLine("* Спринт #1                                                              *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
Console.WriteLine("* Задание #1                                                             *");
Console.WriteLine("* Вариант #19                                                            *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб-24-1                       *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                               *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
Console.WriteLine("* вычисляет результат по формуле (x+10*y)/(x*y) и печатает его на экране.*");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("**************************************************************************");

double x, y;
Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("**************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                              *");
Console.WriteLine("**************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();
