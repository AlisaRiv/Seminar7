//Задача 50. Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же указание,
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.Clear();
int size = 3;

int[,] a = new int[size, size];
System.Random random = new System.Random();
for (int i = 0; i < size; i++) {
    for (int j = 0; j < size; j++) {
        a[i, j] = random.Next(0, 100);
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write("Ведите номер позиции элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m > 0 && m <= size * size) {
  int row = (m - 1) / size;
  int col = (m - 1) % size;
  Console.WriteLine($"{m} -> {a[row, col]}");
} else {
  Console.WriteLine($"{m} -> такого элемента в массиве нет");
}
