/*Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

Console.WriteLine("Введите номер дня недели от 1 до 7, а я попробую угадать его название");
string number = Console.ReadLine();
if (number == "1") Console.WriteLine("Вы загадали понедельник");
else if (number == "2") Console.WriteLine("Вы загадали вторник");
else if (number == "3") Console.WriteLine("Вы загадали среда");
else if (number == "4") Console.WriteLine("Вы загадали четверг");
else if (number == "5") Console.WriteLine("Вы загадали пятницу");
else if (number == "6") Console.WriteLine("Вы загадали субботу");
else if (number == "7") Console.WriteLine("Вы загадали воскресенье");
else Console.WriteLine("Вы ввели некорректные данные");
