Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= N; i++) {
  double cube = Math.Pow(i, 3);
  Console.Write(cube);
  if (i != N) Console.Write(", ");
}