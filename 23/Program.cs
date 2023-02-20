/*Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/


int N() // Ввод числа
{
    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void Cube(int number)
{
    for (int i = 1; i <= number ; i++)
    {
        int cube = i*i*i;
        Console.Write($"{cube}  ");
    }
}

int n = N();
Console.WriteLine($"Кубы от 1 до {n}: ");
Cube(n);