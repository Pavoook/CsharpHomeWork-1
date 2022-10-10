Console.WriteLine("Введите число для проверки на четность:");
string value = Console.ReadLine();
int number = int.Parse(value);

if (number % 2 == 0) Console.WriteLine("Число четное.");
else Console.WriteLine("Число нечетное.");