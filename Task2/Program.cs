// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, 
// k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double b1 = Prompt ($"Введите b1: ");
double k1 = Prompt ($"Введите к1: ");
double b2 = Prompt ($"Введите b2: ");
double k2 = Prompt ($"Введите k2: ");
(double x, double y) = FindXY(b1, b2, k1, k2);

Console.WriteLine($"Координаты точки пересечения = ({x:F3}; {y:F3})");

int Prompt (string message) // метод считывания чисел с консоли
{
    Console.Write(message);
    int number;
    if (int.TryParse(Console.ReadLine(), out number)) // проверка условия корректности ввода
    {
        return number;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);  //прекращение цикла

    return 0;
}

(double, double) FindXY (double b1, double b2, double k1, double  k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}