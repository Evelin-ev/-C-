// Сумма квадратов рандомных чисел


int number1 = new Random().Next(1, 100);
Console.WriteLine(number1);

int result1 = number1 * number1;
Console.WriteLine("Квадрат " + number1 + " = " + result1);

int number2 = new Random().Next(1, 100);
Console.WriteLine(number2);

int result2 = number2 * number2;
Console.WriteLine("Квадрат " + number2 + " = " + result2);

int sum = result1 + result2;

Console.WriteLine("       ");
Console.WriteLine("Квадрат " + number1 + " + квадрат " + number2 + " = " + sum);

