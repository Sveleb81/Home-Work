Console.Write("Введите число: ");
string N = Console.ReadLine();

int sum = 0;
for (int i = 0; i < N.Length; i++) {
    sum += Convert.ToInt16(Convert.ToString(N[i]));
}

Console.Write("Сумма чисел в числе: ");
Console.Write(sum);