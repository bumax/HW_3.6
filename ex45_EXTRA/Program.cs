// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Введите число: ");
var decNumber = Convert.ToInt32(Console.ReadLine());

// Для самопроверки :-)
// Console.WriteLine(Convert.ToString(decNumber, 2));


long Numner2Binary(int source){
    long binNumber = new long();
    int n = new int(); // указатель на разряд

    while (source != 0)
    {
        binNumber += (source % 2) * (long)Math.Pow(10,n); // ищем остаток от деления и смещаем его по разряду
        source /= 2;
        n++;
    }
    return binNumber;
}

Console.WriteLine($"Число {decNumber} в двоичном виде будет {Numner2Binary(decNumber)}");