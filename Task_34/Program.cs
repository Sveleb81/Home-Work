Console.Write("Введите число элементов в массиве: ");
int arrLength = Convert.ToInt32(Console.ReadLine());

int [] arr = new int[arrLength];
Random rnd = new Random();

for (int i = 0; i < arrLength; i++) {
    arr[i] = rnd.Next(100, 999);
}

Console.WriteLine($"Массив: [{String.Join(", ", arr)}]");

int EvenNumbersCount(int arrLength, int [] arr) {
  int count = 0;

  for (int i = 0; i < arrLength; i++) {
    if (arr[i] % 2 == 0) {
        count++;
    }
  }

  return count;
}

Console.WriteLine($"Число четных трехзначных чисел в массиве: {EvenNumbersCount(arrLength, arr)}");