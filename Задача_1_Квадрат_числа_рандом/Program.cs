// Программа на входе принимающая рандомное число, а на выходе выдающая его квадрат


int number = new Random().Next(1, 1000000);
int result = number * number;

Console.WriteLine(number + " в квадрате = " + result);
