﻿using Tyuiu.GolubevDS.Sprint1.Task6.V5.Lib;
DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб 24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать те слова,     *");
Console.WriteLine("* которые являются симметричными                                          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите текст:");
string text = new String(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Результат:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Симметричные слова: " + ds.CheckSymmetricalWords(text));
Console.ReadLine();