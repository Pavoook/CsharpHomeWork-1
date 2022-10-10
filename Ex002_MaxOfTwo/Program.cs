Console.WriteLine("Введите первое число для сравнения:");
string value = Console.ReadLine();
int N1 = int.Parse(value);

Console.WriteLine("Введите второе число для сравнения:");
value = Console.ReadLine();
int N2 = int.Parse(value);

if (N1 > N2){
    Console.Write("Большее из чисел: ");
    Console.WriteLine(N1);
}
else{
    if (N2 > N1){
        Console.Write("Большее из чисел: ");
        Console.WriteLine(N2);
    }
    else{
        Console.WriteLine("Числа равны.");
    }
}