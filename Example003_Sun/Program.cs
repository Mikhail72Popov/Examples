/*int numberA = 3; // int целое число, numberA присваивается - 3.
int numberB = 5;
Console.WriteLine(numberA+numberB);
*/
//или:
/*
int numberA = 3;
int numberB = 5;
int result = numberA+numberB;
Console.WriteLine(result);
*/
//cумма случайных чисел:
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA+numberB;
Console.WriteLine(result);
