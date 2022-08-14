// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumbers(int N)
{
    int i = 1;
    while(i < N)
    {
        System.Console.Write($"{Math.Pow(i, 3)}, ");
        i++;
    }
    System.Console.WriteLine($"{Math.Pow(N, 3)}");
}

System.Console.WriteLine("Введите положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 0)
{
    CubeNumbers(N);
}
else System.Console.WriteLine("Вы ввели отрицательное число");


