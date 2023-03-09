//Задача 52. Задайте двумерный массив из целых чисел.
 //Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.WriteLine("Задача 52");
int size = 3;
int[,] a = new int[size, size];
double[] average = {0, 0, 0}; // new double[size];
System.Random random = new System.Random();
for (int i = 0; i < size; i++) {
    // double ra = 0;
    for (int j = 0; j < size; j++) {
        a[i, j] = random.Next(0, 100);
        average[j] += a[i, j];
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}
bool isFirst = true;
Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < size; i++) {
    average[i] = average[i] / size;
    string prefix = isFirst ? "" : "; ";
    if (isFirst) { isFirst = false; }
    Console.Write($"{prefix}{average[i]: 0.##}");
}
Console.WriteLine();