
long sum = 0;

for (int i = 1; i <= 2000000; i += 1)
{

    if (i == 2 || i == 3)
    {
        sum += i;
        continue;
    }

    for (int divisor = 2; divisor <= (int)Math.Sqrt(i); divisor += 1)
    {
        if (i == divisor)
        {
        continue;
        }

        else if (i % divisor == 0)
        {
        break;
        }
        
        else if (divisor == (int)Math.Sqrt(i))
        {
        sum += i;
        }
    }
}

Console.WriteLine(sum);