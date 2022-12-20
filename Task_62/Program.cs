bool nowGorizontalDirection = true;
bool nowIncreasing = true;
int fixedIndex = 0;
int numberTurns = 0;
int filled = 0;
double [,] arr = new double[4, 4];
string [] indiciesExistingElements = new string[16];

Console.WriteLine("Заполните массив по спирали: "); 
int i = 0;
while (filled != 16) {
    bool nextElementExists;
    if (nowGorizontalDirection) {
      Console.Write($"[{fixedIndex}, {i}]: ");
      arr[fixedIndex, i] = Convert.ToDouble(Console.ReadLine());
      indiciesExistingElements[filled] = $"{fixedIndex}{i}";
      nextElementExists = isExistNextElement(fixedIndex, nowIncreasing ? i + 1 : i - 1);
    } else {
      Console.Write($"[{i}, {fixedIndex}]: ");
      arr[i, fixedIndex] = Convert.ToDouble(Console.ReadLine());
      indiciesExistingElements[filled] = $"{i}{fixedIndex}";
      nextElementExists = isExistNextElement(nowIncreasing ? i + 1 : i - 1, fixedIndex);
    } 
    filled++;

    if ((nowIncreasing && i == 3) || (!nowIncreasing && i == 0) || nextElementExists) {
        numberTurns++;

        nowIncreasing = numberTurns % 2 != 0 ? nowIncreasing : !nowIncreasing;
        int temp = i;
        i = nowIncreasing ? fixedIndex + 1 : fixedIndex - 1;
        fixedIndex = temp;
        nowGorizontalDirection = !nowGorizontalDirection;

        continue;
    };

    if (nowIncreasing) {
        i++;
    } else {
        i--;
    }
}

bool isExistNextElement(int row, int col) {
    for (int i = 0; i < 16; i++) {
        if (indiciesExistingElements[i] == $"{row}{col}") {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Получившийся двумерный массив: ");

for (int k = 0; k < 4; k++) {
    for (int j = 0; j < 4; j++) {
       if (j != 3) {
         Console.Write(arr[k,j] < 10 ? $"0{arr[k,j]}, " : $"{arr[k,j]}, ");
       } else {
         Console.Write(arr[k,j] < 10 ? $"0{arr[k,j]}\n" : $"{arr[k,j]}\n");
       }
    }
}