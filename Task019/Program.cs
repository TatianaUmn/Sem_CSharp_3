// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str_number = number.ToString();

void PalindromeNumber(string str_number)
{
    if(str_number[0] == str_number[4] && str_number[1] == str_number[3])
    {
       Console.WriteLine($"{number} - палиндром."); 
    }
    else Console.WriteLine($"{number} - не палиндром.");
}
if(number > 9999 && number < 100000)
{
    PalindromeNumber(str_number);
}
else Console.WriteLine("Вы ввели не пятизначное число");
