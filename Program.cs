// Подготовил Раевский Р.Ю.

// Task 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Counter(int N)
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