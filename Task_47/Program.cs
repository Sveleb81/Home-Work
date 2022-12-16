Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] arr = new double[m, n];

Random rnd = new Random();

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        int sign = 1;
        if (rnd.NextDouble() > 0.5) {
          sign = -1;
        }

        arr[i, j] = rnd.NextDouble() * rnd.Next() * sign;
    }
}

Console.WriteLine("Получившийся двумерный массив: ");

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
       if (j != n - 1) {
         Console.Write($"{arr[i, j]}, ");
       } else {
         Console.Write($"{arr[i, j]}\n");
       }
    }
}