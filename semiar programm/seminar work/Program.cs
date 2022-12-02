//Домашняя работа 1.

//Задача 1. Написать программу которая принимает два числа

/*Console.Write("Ввести первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;
if(num1 == quad)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
    */


//Задача 2.
/*
Console.Write("Ввести ввести целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = -num;
while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/
/*
12345 / 10 = 1234
12345 / 100 = 123
12345 / 1000 = 12
12345 / 10000 = 1

12345 % 10 = 5
12345 % 100 = 45
12345 % 1000 = 345
12345 % 10000 = 2345
12345 % 100000 = 12345
*/

// Домашняя работа


// Семинар 2.
/*
int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutNumber(randNum);

Console.WriteLine($"Новая версия номера {randNum} это {newNum}");
*/

// Работа в классе
int FindBiggedDigit(int num)
{
    int odin = num / 10;
    int dva = num % 10;
    int result;
    if (odin > dva)
        result = odin;
    else result = dva;

    return result;

}


int randNum = new Random().Next(10, 99);
int newNum = FindBiggedDigit(randNum);

Console.WriteLine("FindBiggedDigit " + newNum);



