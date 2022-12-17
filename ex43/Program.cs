// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// упакуем коэффициеты каждой формулы в свой массив:
double[] f1 = new double[2]; // 0 - k, 1 - b
double[] f2 = new double[2];

Console.Write("Введите k1: ");
f1[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
f1[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
f2[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
f2[1] = Convert.ToDouble(Console.ReadLine());

void CoordCalc(double[] firstF, double[] secondF)
{
    // две прямые пересекаются тогда, когда у них есть общая точка, т.е. координаты этих точек равны:
    // x1 = x2 и y1 = y2 => k1 * x + b1 = k2 * x + b2
    // x * k1 - x * k2 = b2 - b1 => x = (b2 - b1) / (k1 - k2)
    // y = k1 * x + b1 или y = k2 * x + b2
    if (firstF[0] - secondF[0] != 0)
    {
        var x = (secondF[1] - firstF[1]) / (firstF[0] - secondF[0]);
        var y = firstF[0] * x + firstF[1];
        Console.WriteLine($"Точка пересечения заданных прямых имеет координаты ({x}, {y})");
    }
    else // обрабатываем возможные исключения
    {
        if (firstF[1] == secondF[1]) Console.WriteLine("Ошибка! Заданные прямые идентичны и имеют бесконечное число общих точек");
        else Console.WriteLine("Ошибка! Заданные прямые параллельны и не имеют общих точек");
    }

}

CoordCalc(f1, f2);