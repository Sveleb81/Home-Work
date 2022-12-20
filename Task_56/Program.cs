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

int getRowIndexWithLeastSum(double[][] arr, int rows, int cols) {
    int rowIndex = 1;
    double leastSum = getRowSum(arr[0], cols);
    
    for (int i = 1; i < rows; i++) {
        double rowSum = getRowSum(arr[i], cols);

        if (rowSum < leastSum) {
            leastSum = rowSum;
            rowIndex = i + 1;
        }
    }

    return rowIndex;
}

double getRowSum(double[] arr, int length) {
    double sum = 0;
    
    for (int i = 0; i < length; i++) {
        sum += arr[i];
    }

    return sum;
}

int rowIndexWithLeastSum = getRowIndexWithLeastSum(arr, m, n);
Console.WriteLine($"{rowIndexWithLeastSum} строка");

