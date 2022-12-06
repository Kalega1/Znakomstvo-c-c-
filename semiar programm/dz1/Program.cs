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


// Домашнее задание два

//Задача 10. Найти второе число из трех чисел
/*
class Program   
{
static void Main(string[] args)
{
    Console.WriteLine("введите три числа");
    var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));
    while (n >= 100)
    {
        n /= 10;
    }
    var r = n % 10;
    Console.WriteLine(r + " это второе число");
}
}
*/

// Задача 13 Найти третью цифру заданного числа, или сообщить, что ее нет.

/*
int ThirdDigit(int number)

        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
Console.Write("введите любые три цифры: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"третья цифра: {ThirdDigit(number1)}");
*/

//Задача 15. Проверить является ли число дня недели выходным.

/*
Console.Write("Введите число от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 1 && num <= 7)
    {
        if (num == 6 | num == 7) Console.WriteLine("Сегодня выходной");
        else Console.WriteLine("Сегодня рабочий день");
    }
    else Console.WriteLine("Не верное число");
    */
    
    

