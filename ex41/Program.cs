// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите N чисел через запятую: ");
var test = Console.ReadLine().Split(',').Select(int.Parse);

var count = new int();
// перебираем и считаем:
foreach (var item in test) if(item > 0) count++;

Console.WriteLine("Количество положительных чисел: {0}", count);