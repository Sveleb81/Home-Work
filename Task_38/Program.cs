Console.Write("Введите число элементов в массиве: "); 
int arrLength = Convert.ToInt32(Console.ReadLine());

double [] arr = new double[arrLength];

for (int i = 0; i < arrLength; i++) {
    Console.Write($"{i + 1} элемент массива: ");
    double el = Convert.ToDouble(Console.ReadLine());
    arr[i] = el;
}

Console.WriteLine($"Массив: [{String.Join(", ", arr)}]");

double distanceBetweenMaxAndMin(int arrSize, double [] arr) {
    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arrSize; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
        if (arr[i] < min) {
            min = arr[i];
        }
    }

    return max - min;
}

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {distanceBetweenMaxAndMin(arrLength, arr)}");