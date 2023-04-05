using System.Text;
Console.OutputEncoding = Encoding.UTF8; 

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
for (int i = number1; i <= number2; i++)
{
    if (i == 2 || i == 3 ||i==5 || i==7)
    {
        Console.WriteLine($"{i}-простое число");
    }
    
     else if (i %2==0|| i%3==0 ||i%5==0 || i%7==0)
    {
        Console.WriteLine($"{i}-сложное число");
       
    }
    else
    {
        Console.WriteLine($"{i}-простое число");

    }


}
