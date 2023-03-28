// Подготовил Раевский Р.Ю.

// Task 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* int Counter(int N)
{
    int count = 0;
    for(int i = 0; i < N; i++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел планируете проверить: ");
int quan = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Итого чисел больше 0: {Counter(quan)}");
*/

// Task 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Cross(double a, double b, double c, double d)
{
    if(a == c && b == d) Console.WriteLine("Эти одна прямая!");
    else if(a == c) Console.WriteLine("Эти прямые параллельны"); 
    else
    {
        double x = (d - b)/(a - c);
        double y = a*x + b;
        Console.WriteLine($"У заданных прямых точкой пересечения является x: {x}; y: {y}");
    }
}

Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Cross(k1, b1, k2, b2);