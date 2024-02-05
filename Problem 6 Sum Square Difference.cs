
// difference between sum of squares and square of sum is equal to 
// the sum of double of the products : 
//(a + b + c)² = a² + b² + c² + 2ab + 2bc + 2ca
// thus the only number worth calculating is 2 * (1*2, 1*3...2*1, 2*3... 100)
// (all products excluding squares)

int result = 0;

for (int a = 1; a <= 100; a++)
{
    for (int b = 1; b <= 100; b++)
    {
        if (b == a)
        {
            continue; // here we exclude squares
        }
        else
        {
            result += a * b;
        }
    }
}

Console.WriteLine(result);
Console.ReadKey();
