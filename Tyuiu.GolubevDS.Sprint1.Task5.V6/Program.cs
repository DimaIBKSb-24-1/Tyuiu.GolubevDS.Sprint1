using Tyuiu.GolubevDS.Sprint1.Task5.V6.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб 24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение      *");
Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели  (понедельник,    *");
Console.WriteLine("* вторник,..., воскресенье) приходится k-й день невисокосного года,       *");
Console.WriteLine("* в котором 1 января – понедельник.                                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int k;

Console.WriteLine("Введите номер дня от 1 до 365");
k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
if (k < 1 || k > 365)
{
    Console.WriteLine("Вы вышли за пределы дней года");
}
else
    Console.WriteLine(ds.Calculate(k) + "-й день недели");

Console.ReadKey();
