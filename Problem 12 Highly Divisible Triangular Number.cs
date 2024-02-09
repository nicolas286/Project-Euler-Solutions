
int triangleNumber = 1;
int counter = 2;
int divisorCount = 0;
bool answerFound = false;

while (answerFound == false)
{
  
  divisorCount = 0;

  triangleNumber += counter;

  for (int divisor = 1; divisor <= (int)Math.Sqrt(triangleNumber); divisor++)
  {
   if (triangleNumber % divisor == 0)
   {
      divisorCount += 2;
   }
  }

  if (divisorCount > 500)
  {
   answerFound = true;
  }

  Console.WriteLine(divisorCount);

  counter++;

}

Console.WriteLine(triangleNumber);

