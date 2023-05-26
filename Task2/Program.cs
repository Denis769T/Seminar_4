// // Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // 9012 -> 12

int ReadInt(string text) //Вызов функции ReadInt
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Введите число : ");
int sum = 0;// Число цифр в строке.
int m=number;
int a=number;
int b=number;
int s=0;
//---------------------------------------
while (number != 0) // Подсчёт цифр в строке.
{
    number /= 10;
    sum += 1;
}   

 for ( int i=1 ; i <= sum; i++)
{
    a=b%10;
    s+=a;
    b=b/10;
}
Console.WriteLine($"сумма введёных чисел равна : {s}");