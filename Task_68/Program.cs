Console.Write("Введите m: ");
long m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
long n = Convert.ToInt32(Console.ReadLine());

long Akk(long m, long n) {
    if (m == 0) return n + 1;

    if (m > 0 && n == 0) return Akk(m - 1, 1);

    return Akk(m - 1, Akk(m, n - 1));
}

Console.Write($"A(m,n) = {Akk(m, n)}");

