// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//----------------------------------------
int ReadInt(string text) //Вызов функции ReadInt
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
} 

int A = ReadInt("Введите число A=");
int B = ReadInt("Введите число B=");
int i=0;
int m=A;

for( i=B; i!=1; i--)
{
    A *= m;
}
Console.Write($"C={A}");
