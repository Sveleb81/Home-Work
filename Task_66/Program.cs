Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int getSumInRange(int start, int end, int sum) {
    if (start == end) return sum + end;

    return getSumInRange(start, end - 1, end + sum);
}

int sum = M > N ? getSumInRange(N, M, 0) : getSumInRange(M, N, 0);
Console.Write($"Сумма натуральных элементов в промежутке от M до N: {sum}");

