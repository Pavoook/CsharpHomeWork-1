Console.WriteLine("Введите верхнюю границу для ряда положительных четных чисел:"); // ввод числа
string value = Console.ReadLine();
int number = int.Parse(value);

int count = 2; // вывод ряда положительных четных чисел, кроме последнего, через зяпятую
while (number > count + 1){
    Console.Write(count);
    Console.Write(", ");
    count = count + 2;
}

if (number % 2 == 0) Console.Write(number); // отдельный вывод последнего члена ряда, чтобы в конце ряда не было запятой
else if (number > 1) Console.Write(number - 1);