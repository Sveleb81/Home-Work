Console.WriteLine("Введите число: ");
string N = Console.ReadLine();

if (N[0] == N[4] && N[1] == N[3]) {
  Console.WriteLine("Введенное число является палиндромом");
} else {
  Console.WriteLine("Введенное число не является палиндромом");
}