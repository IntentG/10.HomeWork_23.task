//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int cube = 1;

int CubeNumber(int number)
{
        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
                {
                    cube = i * i * i;
                    Console.Write($"| {cube,2}");
                }
            Console.Write($"   -> Таблица кубов чисел от 1 до {number}");
        }
        else
        {
            Console.WriteLine("Расчёт будет произведён от 1.\nВведите число больше 0");
        }
    return cube;
}

int result = CubeNumber(number);
