using Tyuiu.GolubevDS.Sprint1.Task7.V18.Lib;
DataService ds = new DataService();
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #18                                                          *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб 24-1                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение       *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                *");
Console.WriteLine("* Ответ округлить до 3ех  знаков после запятой.                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

int x;
Console.WriteLine("Введите значение X");
x = Convert.ToInt32(Console.ReadLine());

int y;
Console.WriteLine("Введите значение Y");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Результат формулы = " + Math.Round(ds.Calculate(x,y), 3));

Console.ReadLine();
