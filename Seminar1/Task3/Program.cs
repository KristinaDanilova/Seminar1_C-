﻿Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());
if (0 < day && day < 8)
{
   if (day == 1) Console.WriteLine("Понедельник");
   if (day == 2) Console.WriteLine("Вторник");
   if (day == 3) Console.WriteLine("Среда");
   if (day == 4) Console.WriteLine("Четверг");
   if (day == 5) Console.WriteLine("Пятница");
   if (day == 6) Console.WriteLine("Суббота");
   if (day == 7) Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Не правильный день недели");
}
