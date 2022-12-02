//Урок 1.

//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Ввести первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine(num1 + " = макс, " + num2 + " = мин. ");
if(num1 < num2)
    Console.WriteLine(num2 + " = макс, " + num1 + " = мин. ");
    */


//задача 2. Найти максимальное число из трех чисел
/*Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 & num1 > num3)
    Console.WriteLine(num1 + " = макс");
else 
    if(num2 > num1)
        Console.WriteLine(num2 + " = макс");
    else
        Console.WriteLine("они все равны");
Console.ReadKey();
*/

// Задача 3. Поиск проверка числа на четнось
/*
int a;                             
Console.Write("введите любое число: ");
a= Console.Read(); 
if (a % 2==1)
    Console.WriteLine("это число нечетное");
    else
        Console.WriteLine("это число четное");
Console.ReadKey();
*/

// Задача 4. Найти все четные числа от 1 до n
/*
Console.WriteLine("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);
*/

