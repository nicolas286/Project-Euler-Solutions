
int sumThree = 0;
int sumFive = 0;

// looping through all multiples of 3 between 3 and 1000 

for (int i = 3; i <= 1000; i = i + 3)
{
    /* if multiple of 3 is also a multiple of 5, it is not added to sumThree
      this avoids counting the same numbers two times */

    if ((i % 5) != 0) {
    sumThree = sumThree + i;
    }
    
}

// looping through all multiples of 5 between 5 and 999 

for (int i = 5; i <= 999; i = i + 5)
{
    sumFive = sumFive + i;
}

Console.WriteLine(sumThree);
Console.WriteLine(sumFive);
Console.WriteLine(sumThree + sumFive);