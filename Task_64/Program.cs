Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

void outputNaturalNumbersUpToN(int N) {
    if (N == 1) {
        Console.Write($"{N}");
        return;
    };

    Console.Write($"{N}, ");
    outputNaturalNumbersUpToN(N - 1);
}

outputNaturalNumbersUpToN(N);