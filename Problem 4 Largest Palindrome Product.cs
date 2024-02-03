
List<int> palindromeList = new List<int>();
int answer = 0; 

for (int firstNumber = 999; firstNumber >= 100; firstNumber--) // finding every palindrome that is the product of 2 3-digit numbers
{
    for (int secondNumber = 999; secondNumber >= 100; secondNumber--)
    {
        int product =  firstNumber * secondNumber ;
        int productToReverse = product;
        int reverse = 0;
        int remainder;

        while (productToReverse != 0) // reversing number to check if palindrome
         {
            remainder = productToReverse % 10;
            reverse = reverse * 10 + remainder;
            productToReverse /= 10;
         }

        if (product == reverse)
        {
        palindromeList.Add(product); // each palindrome is added to the list
        }
    }
}

answer = palindromeList.Max(); // select highest palindrome
Console.WriteLine(answer);
Console.ReadKey();


