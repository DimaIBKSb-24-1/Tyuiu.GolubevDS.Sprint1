using Tyuiu.GolubevDS.Sprint1.Task3.V4.Lib;

Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #4                                                           *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб 24-1                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу вычисления стоимости покупки, состоящей из        *");
Console.WriteLine("* нескольких тетрадей и такого же количества обложек к ним. Ответ      *");
Console.WriteLine("* округлить до 3ех  знаков после запятой.                              *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

double priceNotebook;
Console.WriteLine("Введите цену тетради: ");
priceNotebook = Convert.ToDouble(Console.ReadLine());

double priceCover;
Console.WriteLine("Введите цену обложки: ");
priceCover = Convert.ToDouble(Console.ReadLine());

int quantity;
Console.WriteLine("Введите кол-во комплектов: ");
quantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine(new DataService().PurchaseAmount(priceNotebook, priceCover, quantity));


Console.ReadKey();