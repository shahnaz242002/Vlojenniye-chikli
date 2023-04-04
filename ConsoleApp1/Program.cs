using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
while (number1 != 0)
{
    int ostatok1 = number1 % 10;
    int tmp = number2;

    while (tmp != 0)
    {
        int ostatok2 = tmp % 10;


        if (ostatok1 == ostatok2)
        {
            Console.WriteLine("Да");
            return;
        }

        tmp /= 10;

    }

    number1 /= 10;
}

Console.WriteLine("Нет");