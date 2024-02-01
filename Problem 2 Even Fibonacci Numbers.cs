
int valuesSum = 2;
int firstValue = 1;
int secondValue = 2;
int currentValue = firstValue + secondValue;

while (currentValue <= 4000000) {
    if (currentValue % 2 == 0) {
    valuesSum += currentValue; 
    }
    firstValue = secondValue;
    secondValue = currentValue;
    currentValue = firstValue + secondValue;
};

Console.WriteLine(valuesSum);
Console.ReadKey();

