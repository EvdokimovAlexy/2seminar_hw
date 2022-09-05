Console.WriteLine("Введите  число");
int numberA = Convert.ToInt32(Console.ReadLine());
int firstdigit = multiply(numberA);

Console.WriteLine(firstdigit);

int multiply (int num1)
{
    return (num1 /10) %10;
             
}