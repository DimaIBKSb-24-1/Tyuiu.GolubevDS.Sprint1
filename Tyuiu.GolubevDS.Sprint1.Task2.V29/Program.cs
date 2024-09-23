using Tyuiu.GolubevDS.Sprint1.Task2.V29.Lib;

Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                  *");
Console.WriteLine("* Задание #2                                                           *");
Console.WriteLine("* Вариант #29                                                          *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб 24-1                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Пользователем задается количество секунд.                            *");
Console.WriteLine("* Перевести время в полные минуты                                      *");
Console.WriteLine("* И напечатать его на экране.                                          *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

int seconds;
Console.WriteLine("Введите количество секунд: ");
seconds = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");
var ds = new DataService();

Console.WriteLine(ds.ConvertSecondsToHours(seconds));

Console.ReadKey();
