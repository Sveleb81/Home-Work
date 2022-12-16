Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] arr = new double[m, n];

Console.WriteLine("Заполните массив");
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        Console.Write($"[{i}, {j}]: ");
        arr[i, j] = Convert.ToDouble(Console.ReadLine());
    }
}

void findElementInArrayByIndicies(double [,] arr, int rows, int cols, int x, int y) {
    if (x >= rows || y >= cols) {
      Console.WriteLine("Tакого числа в массиве нет");
      return;
    }
     
     Console.WriteLine($"Искомое число: {arr[x, y]}");
}

void findElementInArray(double [,] arr, int rows, int cols, double num) {
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if (arr[i, j] == num) {
                Console.WriteLine($"Индекс числа {num}: [{i}, {j}]");
                return;
            }
        }
    }

    Console.WriteLine("Tакого числа в массиве нет");
}

Console.Write("Введите индекс строки: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

findElementInArrayByIndicies(arr, m, n, x, y);

Console.Write("Введите число, которое хотите найти в массиве и получить его индекс: ");
double num = Convert.ToDouble(Console.ReadLine());

findElementInArray(arr, m, n, num);