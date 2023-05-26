// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// int[] FillArray(int size, int leftRange, int rightRange)

// void FillArray(int[] Array)
// {
//     int[] arr = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i <= size; i++)
//     {
//         arr[i] = rand.Next(leftRange,rightRange+1);
//      }
// return arr;
// }

// void PrintArray(int[]Array)
// {
//     Console.WriteLine(string.Join(" ", Array));
// }

Console.Write("Введите колличество элементов в массиве :");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите левую границу массива :");
int leftRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правую границу массива :");
int rightRange = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i <= size-1; i++)
{
    arr[i] = rand.Next(leftRange, rightRange);
}

//int n = 2;
//int[] arr = new int [size];
//FillArray(size,leftRange,rightRange);
Console.Write("["+string.Join(", ", arr)+"]");