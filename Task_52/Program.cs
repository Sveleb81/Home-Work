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

double[] getAverageEachCol(double [,] arr, int rows, int cols) {
    double[] averageArr = new double[cols];

    for (int j = 0; j < cols; j++) {
        double sum = 0;
        for (int i = 0; i < rows; i++) {
            sum += arr[i, j];
        }
        averageArr[j] = sum / rows;
    }

    return averageArr;
}

double[] averageArr = getAverageEachCol(arr, m, n);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < n; i++) {
    Console.Write($"{averageArr[i]}; ");
}