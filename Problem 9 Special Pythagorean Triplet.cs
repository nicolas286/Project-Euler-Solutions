
int a = 0;
int b = 0;
int c = 0;

for (a = 0; a <= 500; a++)

{
    for (b = a+1; b <= 500; b++)
    {
        for (c = b+1; c <= 500; c++)
        {
            if ( a + b + c == 1000 && ( a * a ) + ( b * b ) == ( c * c) )
            {
                Console.WriteLine(a * b * c); 
            }

            else
            {
                continue;
            }
        }
    }
}