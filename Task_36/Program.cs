Console.Write("Введите число элементов в массиве: ");
int arrLength = Convert.ToInt32(Console.ReadLine());

int [] arr = new int[arrLength];
Random rnd = new Random();

for (int i = 0; i < arrLength; i++) {
    arr[i] = rnd.Next(-100, 100);
}

Console.WriteLine($"Массив: [{String.Join(", ", arr)}]");

int getSumElementsInOddIndicies (int arrSize, int [] arr) {
    int sum = 0;
    for (int i = 0; i < arrSize; i++) {
      if (i % 2 != 0) {
        sum += arr[i];
      }
    }

    return sum;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {getSumElementsInOddIndicies(arrLength, arr)}");