//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.Clear();
Console.WriteLine("Задача 47");

Console.Write("Ведите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n}");

int[,] a = new int[m, n];
System.Random random = new System.Random();
for (int i = 0; i < m; i++) {
    bool isFirst = true;
    for (int j = 0; j < n; j++) {
        a[i, j] = random.Next(-100, 100);
        string prefix = isFirst ? "" : ", ";
        if (isFirst) { isFirst = false; }
        Console.Write($"{prefix}{a[i, j]}");
    }
    Console.WriteLine();
}