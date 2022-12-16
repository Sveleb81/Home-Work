Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());

double [] arr = new double[M];

for (int i = 0; i < M; i++) {
    Console.Write($"{i + 1} число: ");
    arr[i] = Convert.ToDouble(Console.ReadLine());
}

int getPositiveElementsCount(double [] arr, int arrLength) {
  int count = 0;

  for (int i = 0;  i < arrLength; i++) {
    if (arr[i] > 0) count++;
  }

  return count;
}

Console.WriteLine($"Чисел больше нуля: {getPositiveElementsCount(arr, M)}");