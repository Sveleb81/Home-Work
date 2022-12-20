Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[][] arr = new double[m][];

for (int i = 0; i < m; i++) {
    arr[i] = new double[n];
}

Console.WriteLine("Заполните массив");
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        Console.Write($"[{i}, {j}]: ");
        arr[i][j] = Convert.ToDouble(Console.ReadLine());
    }
}

double[][] sortTwoDemensionsArr(double[][] arr, int rows, int cols) {
    for (int i = 0; i < rows; i++) {
        arr[i] = sortOneDemensionArr(arr[i], cols);
    }

    return arr;
}

double[] sortOneDemensionArr(double[] arr, int length) {
    for(int i = 0; i < length; i++) {
        for (int j = 0; j < length; j++) {
            if (j == length - 1) continue;

            if (arr[j + 1] > arr[j]) {
                double temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }

    return arr;
}

sortTwoDemensionsArr(arr, m, n);

Console.WriteLine("Получившийся двумерный массив: ");

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
       if (j != n - 1) {
         Console.Write($"{arr[i][j]}, ");
       } else {
         Console.Write($"{arr[i][j]}\n");
       }
    }
}