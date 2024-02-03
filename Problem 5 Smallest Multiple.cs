bool answerFound = false;
int answer = 0;
int testNumber = 20;

while (answerFound == false) {

    for (int divider = 19; divider >= 3; divider--)
    {

        if (divider == 4 || divider == 5 || divider == 10) {
            continue;
        }

        if ((testNumber % divider) != 0) {
            break;
        }

        if (divider == 3) {
            answerFound = true;
            answer = testNumber;
        }
    }

        testNumber += 20;
}

Console.WriteLine(answer);

