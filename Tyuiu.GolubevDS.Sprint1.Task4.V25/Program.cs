using Tyuiu.GolubevDS.Sprint1.Task4.V25.Lib;
DataService ds = new DataService();
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #25                                                          *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб 24-1                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные      *");
Console.WriteLine("* данные, вычисляет результат по формуле и печатает его на экране      *");
Console.WriteLine("* Ответ округлить до 3ех  знаков после запятой.                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

int a;
Console.WriteLine("Введите значение А");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(("1 - CosA / Sin2 A = ") + ds.Calculate(a));

Console.ReadLine();
