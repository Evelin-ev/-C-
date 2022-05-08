// Сумма квадратов чисел

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

int result1 = number1 * number1;
Console.WriteLine("Квадрат " + number1 + " = " + result1);

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());


int result2 = number2 * number2;
Console.WriteLine("Квадрат " + number2 + " = " + result2);

int sum = result1 + result2;

Console.WriteLine("       ");
Console.WriteLine("Квадрат " + number1 + " + квадрат " + number2 + " = " + sum);

