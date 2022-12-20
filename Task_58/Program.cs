Console.Write("Введите число строк первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());

double[][] firstArr = new double[m1][];

for (int i = 0; i < m1; i++) {
    firstArr[i] = new double[n1];
}

Console.WriteLine("Заполните первую матрицу");
for (int i = 0; i < m1; i++) {
    for (int j = 0; j < n1; j++) {
        Console.Write($"[{i}, {j}]: ");
        firstArr[i][j] = Convert.ToDouble(Console.ReadLine());
    }
}

Console.Write("Введите число строк второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());

double[][] secondArr = new double[n2][];

for (int i = 0; i < n2; i++) {
    secondArr[i] = new double[m2];
}

if (n2 != m2) {
    throw new Exception("Некорректная размерность матриц(см. 'правила умножения матриц')");
}

Console.WriteLine("Заполните вторую матрицу");
for (int i = 0; i < m2; i++) {
    for (int j = 0; j < n2; j++) {
        Console.Write($"[{i}, {j}]: ");
        secondArr[j][i] = Convert.ToDouble(Console.ReadLine());
    }
}

double[,] multMatrix(double[][] firstMatrix, double[][] secondMatrix) {
    double[,] resultMatrix = new double[m1, n2];
    for (int i = 0; i < m1; i++) {
        for (int j = 0; j < n2; j++) {
            resultMatrix[i, j] = getMultMatrixElement(firstMatrix[i], secondMatrix[j]);
        }
    }

    return resultMatrix;
}

double getMultMatrixElement(double[] firstMatrixRow, double[] secondMatrixCol) {
    double element = 0;

    for (int i = 0; i < n1; i++) {
        element += firstMatrixRow[i] * secondMatrixCol[i];
    }

    return element;
}

double[,] resultMatrix = multMatrix(firstArr, secondArr);

Console.WriteLine("Получившаяся матрица: ");

for (int i = 0; i < m1; i++) {
    for (int j = 0; j < n2; j++) {
       if (j != n2 - 1) {
         Console.Write($"{resultMatrix[i,j]}, ");
       } else {
         Console.Write($"{resultMatrix[i,j]}\n");
       }
    }
}