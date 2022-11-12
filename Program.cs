Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine("Число A больше числа B");
if (number2 > number1)
    Console.WriteLine("Число B больше числа A");
if (number1 == number2)
    Console.WriteLine("Число А равно числу Б");