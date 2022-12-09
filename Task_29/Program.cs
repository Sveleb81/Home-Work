Console.Write("Введите число элементов в массиве: "); 
int N = Convert.ToInt32(Console.ReadLine());

int [] arr = new int[N];

for (int i = 0; i < N; i++) {
    Console.Write(i + 1);
    Console.Write(" элемент массива: ");
    int el = Convert.ToInt32(Console.ReadLine());
    arr[i] = el;
}
Console.Write("[");
Console.Write(String.Join(", ", arr));
Console.Write("]");