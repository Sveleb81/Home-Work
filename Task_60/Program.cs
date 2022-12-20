Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());

if (x*y*z > 89) {
    throw new Exception("Превышен максимальный размер трехмерного массива, который может содержать уникальные двухзначные числа");
}

int[,,] arr = new int[x, y, z];
int[] uniqueRandomNumbers = new int[x*y*z];
int nextNullableIndex = 0;

Random rnd = new Random();
for (int i = 0; i < x; i++) {
    for (int j = 0; j < y; j++) {
        for (int k = 0; k < z; k++) {
            arr[i, j, k] = getUniqueNumber();
        }
    }
}

int getUniqueNumber() {
    int randomNumber = rnd.Next(10, 99);
        if (isUniqueNumber(randomNumber)) {
            uniqueRandomNumbers[nextNullableIndex++] = randomNumber;
            return randomNumber;
        } else {
            return getUniqueNumber();
        }
}

Boolean isUniqueNumber(int num) {
    for (int i = 0; i < x*y*z; i++) {
        if (uniqueRandomNumbers[i] == num) return false;
    }

    return true;
}

Console.WriteLine("Получившийся трехмерный массив: ");

for (int k = 0; k < z; k++) {
    for (int i = 0; i < x; i++) {
        for (int j = 0; j < y; j++) {
            if (j != y - 1) {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}), ");
            } else {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})\n");
            }   
        }
    }
}