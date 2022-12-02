Console.WriteLine("Zadacha41\n");

void Zadacha41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
    // сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2

    Console.Write("Введите количество чисел:  ");
    int count = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[count];
    int i;
    int resalt = 0;
    for (i = 0; i < count; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    for (i = 0; i < count; i++)
    {
        if (array[i] > 0)
        {
            resalt = resalt + 1;
        }

    }   Console.WriteLine($"пользователь ввёл из {count} чисел {resalt} > 0");

}   

Zadacha41();
Console.WriteLine();
Console.WriteLine("Zadacha43\n");

void Zadacha43()
{
    // Задача 43: Напишите программу, которая найдёт точку пересечения 
    // двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
    //  значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    
    Console.Write("Введите число k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b1: "); 
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    double x = Math.Round((b2 - b1)/(k1 - k2), 2);
    double y = Math.Round((k1*x + b1), 2);
    Console.WriteLine($"Координаты точки пересечения двух прямых: ({x};{y})"); 
}

Zadacha43();