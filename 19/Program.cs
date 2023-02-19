/*Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно палиндромом.*/

int Number() // Ввод числа
{
    Console.WriteLine("Введите число и я скажу полиндром ли это: ");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

bool range(int N) // Проверка корректного ввода
{
    if (N > 9999 && N < 100000) return true;
    else return false;
}

void Palindrom(int N) // Проверка на палиндром
{
    if (range(N))
{
    if(N/10000 == N % 10 && (N/1000)%10 == (N%100)/10)
    {
        Console.WriteLine("Да, это палиндром");
    }
    else Console.WriteLine("Нет, это не палиндром");
} 
else Console.WriteLine("Число не пятизначное!");
}

int N = Number();
Palindrom(N);
