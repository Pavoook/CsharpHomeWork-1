Console.WriteLine("Введите первое число для сравнения:"); // ввод 1-го числа
string value = Console.ReadLine();
int N1 = int.Parse(value);

Console.WriteLine("Введите второе число для сравнения:"); // ввод 2-го числа
value = Console.ReadLine();
int N2 = int.Parse(value);

Console.WriteLine("Введите третье число для сравнения:"); // ввод 3-го числа
value = Console.ReadLine();
int N3 = int.Parse(value);

int max = N1; // нахождение максимума
if (max < N2){
    max = N2;
}
if (max < N3){
    max = N3;
}

if (N1 == N2 & N2 == N3){ // проверка на равенство всех чисел
    Console.WriteLine("Числа равны.");
}
else{
    Console.Write("Большее значение: "); // вывод результата
    Console.WriteLine(max);
}