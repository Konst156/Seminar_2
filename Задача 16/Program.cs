Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a * a == b){
    Console.WriteLine($"Число {b} является квадратом числа {a}");
}
if (b * b == a){
    Console.WriteLine($"Число {a} является квадратом числа {b}");
} else{
    Console.WriteLine("Нет");
}