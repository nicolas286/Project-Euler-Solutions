
int primesFound = 1; // set at 1 to account for number 2
int i = 0;
long answer = 0;
bool isPrime = true;

while (primesFound <= 10001)
{

  long numberTested = (2 * i) + 1; // only tests odd numbers

  for (int divider = 2; divider <= (int)Math.Sqrt(numberTested); divider++)
  {
    if ((numberTested % divider) == 0)
    {
      isPrime = false;
      break;
    }
    if (divider == (int)Math.Sqrt(numberTested))
    {
      isPrime = true;
    }
  }

  if (isPrime == true) {
    primesFound++;
  }

  i++; 
  answer = numberTested;
}

Console.WriteLine(answer);
Console.ReadKey();
