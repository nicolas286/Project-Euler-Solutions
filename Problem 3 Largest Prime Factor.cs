
long numberToFactorize = 600851475143;
long answer = 0;

for (long i = 2; i <= numberToFactorize / 2 ; i++) // we start loop from the bottom (faster)
 {

  if (numberToFactorize % i == 0) // if number is divisible by i
    {

      long oppositeDivider = numberToFactorize / i; // gets to larger divider

      for(int primeChecker = 2; primeChecker <= (int)Math.Sqrt(oppositeDivider); primeChecker++)  // loop to check if larger divider is prime
      {
       
        if ((oppositeDivider % primeChecker) == 0) // break the loop as soon as a divider is found, which means it's not a prime number
        {
         break;
        }

        if (primeChecker == (int)Math.Sqrt(oppositeDivider)) // if gets to the end of the loop, it means larger divider is prime : it is our answer
        {
         answer = oppositeDivider;
         goto Found;
        }

      }
    }    
}

Found:
  Console.WriteLine(answer);   
  Console.ReadKey();







