// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PositiveNumbers()
{
    Console.Write("Введите числа через пробел: ");
    
    var input = Console.ReadLine();
    var array = input.Split(' ');
    int res = 0;

    for (int i = 0; i < array.Length; i++)

        {
            if (int.Parse(array[i]) > 0) res++;
        }

    Console.WriteLine($"Количество положительных чисел: {res}");
}

PositiveNumbers();