using System;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace Task_5__2_
{
    internal class Program
    {
        //The tasks were done using methods.
        static void Main(string[] args)
        {

        }


        static int ReadInt(string caption, string errorMessage)
        {
            var backupColor = Console.ForegroundColor;

        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(caption);
            Console.ForegroundColor = backupColor;

            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int a);

            if (!state)
            {
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ForegroundColor = backupColor;
                }
                goto l1;
            }
            return a;
        }

        static int Checker(string caption, string errorMessage)
        {
            var backupColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            int b = ReadInt("Add the digit count for your desired number:", "the digit number should be whole number, add new one;");
            Console.ForegroundColor = backupColor;

        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(caption);
            Console.ForegroundColor = backupColor;

            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int a);

            if (!state)
            {
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ForegroundColor = backupColor;
                }
                goto l1;
            }
            else if (a < Math.Pow(10, b - 1) || a > Math.Pow(10, b))
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Input should contain {b} digits, please, enter the new one");
                Console.ForegroundColor = backupColor;
                goto l1;
            }
            return a;
        }

        static int Checker2(string caption, string errorMessage, int digitNumber)
        {
            var backupColor = Console.ForegroundColor;

        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(caption);
            Console.ForegroundColor = backupColor;

            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int a);

            if (!state)
            {
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ForegroundColor = backupColor;
                }
                goto l1;
            }
            else if (a < Math.Pow(10, digitNumber - 1) || a > Math.Pow(10, digitNumber))
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Input should contain {digitNumber} digits, please, enter the new one");
                Console.ForegroundColor = backupColor;
                goto l1;
            }
            return a;
        }

        static int[] SeparateDigitsAndAddToArray(int number)
        {
            // Convert the number to a string to easily access each digit
            string numberStr = number.ToString();

            // Initialize an array to store the separated digits
            int[] digitsArray = new int[numberStr.Length];

            // Iterate through each character in the string representation of the number
            for (int i = 0; i < numberStr.Length; i++)
            {
                // Convert the character back to an integer and add it to the array
                digitsArray[i] = int.Parse(numberStr[i].ToString());
            }

            return digitsArray;
        }

        void Task5E1()
        {
            //1) verilmiş 4 reqemli ededin reqemlerinin cemini tap
            // Step 1: Get a valid 4 - digit integer input from the user
            int a = Checker("Add input: ", "Input should be a whole number, please add another one");

            // Step 2: Separate the digits of the input number and add them to an array
            int[] resultArray = SeparateDigitsAndAddToArray(a);

            // Step 3: Calculate the sum of the digits in the array
            int sum = 0;
            foreach (int digit in resultArray)
            {
                sum = sum + digit;
            }

            // Step 4: Display the sum of the digits
            Console.WriteLine(sum);
        }

        void Task5E2()
        {
            //2) verilmiş 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3
            int a = Checker("Add Input: ", "Input should be whole number, please, add another one");
            int[] resultArray = SeparateDigitsAndAddToArray(a);
            int sum = resultArray[0] + resultArray[1] + resultArray[2];
            Console.WriteLine($"The sum of three first digits is {sum}");
        }

        void Task5E3()
        {
            //3) verilmiş 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
            int a = Checker("Add Input: ", "Input should be whole number, please, add another one");
            int[] resultArray = SeparateDigitsAndAddToArray(a);
            int sum = resultArray[resultArray.Length / 2 - 1] + resultArray[resultArray.Length / 2] + resultArray[resultArray.Length / 2 + 1];
            Console.WriteLine($"The sum of middle digits is {sum}");
        }

        void Task5E4()
        {
            //4) verilmiş 5 reqemli ilk ve son reqemlerinin ceminin kvadrati

            // Use the Checker method to get a valid integer input from the user
            int a = Checker("Add Input: ", "Input should be a whole number, please add another one");

            // Separate the digits of the input number and add them to an array
            int[] resultArray = SeparateDigitsAndAddToArray(a);

            // Calculate the sum of the first and last digit of the array
            int sum = resultArray[0] + resultArray[resultArray.Length - 1];

            // Calculate the square of the sum
            int result = sum * sum;

            // Display the final result
            Console.WriteLine($"The result is {result}");
        }

        void Task5E5()
        {
            //5) verilmiş 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            int a = Checker("Add Input: ", "Input should be a whole number, please add another one");
            string aStr = a.ToString();

            // Extract the first digit
            char firstDigitChar = aStr[0];

            // Append the first digit to the end of the string
            string resultStr = aStr + firstDigitChar;

            // Remove the original first digit
            resultStr = resultStr.Substring(1);

            // Convert the result back to an integer
            int resultNumber = int.Parse(resultStr);

            //Print the result
            Console.WriteLine(resultNumber);
        }

        void Task5E6()
        {
            //6) verilmiş 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
            int a = Checker("Add Input: ", "Input should be a whole number, please add another one");
            // Separate the digits of the input number and add them to an array
            int[] resultArray = SeparateDigitsAndAddToArray(a);

            //Remove the last digit
            a /= 10;
            string aStr = a.ToString();

            //Remove the first digit
            string resultString = aStr.Substring(1);
            int result = Convert.ToInt32(resultString);
            Console.WriteLine(result);
        }

        void Task5E7()
        {
            //7) verilmiş 4 reqemli ededin tersine duzub axirina ve evveline 8 artir

            int input = Checker("Add Input: ", "Input should be a whole number, please add another one");
            string newNumberStr = "8" + input.ToString() + "8";
            int newNumber = int.Parse(newNumberStr);
            Console.WriteLine(newNumber);
        }

        void Task5E8()
        {
        //8) verilmiş ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  
        s1:
            int input = Checker("Add Input: ", "Input should be a whole number, please add another one");
            if (input < 100)
            {
                Console.WriteLine("The digit should have at least three digits");
                goto s1;
            }
            int lastDigit = input % 10;
            int lastThirdDigit = (input / 100) % 10;
            int result = lastDigit + lastThirdDigit;
            Console.WriteLine($"The result is {result}");
        }

        void Task5E9()
        {
            //9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439
            int number = Checker("Add Input: ", "Input should be a whole number, please add another one");
            string numberStr = number.ToString();
            string newFullNumberStr = "";
            for (int i = 0; i < numberStr.Length; i = i + 2)
            {
                newFullNumberStr += numberStr[i];

            }

            Console.WriteLine(newFullNumberStr);

        }

        void Task5E10()
        {
            /* 10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
    sonra cut yerde dayanlarinda bir eded duzlet,
    sonra onlari topla*/

            int number = Checker("Add input: ", "Input should be a whole number, please add another one");
            string numberStr = number.ToString();
            string firstFullNumberStr = "";
            string secondFullNumberStr = "";
            for (int i = 0; i < numberStr.Length; i = i + 2)
            {
                firstFullNumberStr += numberStr[i];

            }
            int firstFullNumber = int.Parse(firstFullNumberStr);

            for (int i = 1; i < numberStr.Length; i = i + 2)
            {
                secondFullNumberStr += numberStr[i];

            }
            int secondFullNumber = int.Parse(secondFullNumberStr);

            int sum = firstFullNumber + secondFullNumber;
            Console.WriteLine("The result is " + sum);
        }

        void Task5E11()
        {
            /*11) 11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            Qruplarin cemini tap.
            Alinan cavabin axirina 99 artir.
            Sonra cavabin ozunden onun 18 % ni cix;*/
            int i;
            int sum = 0;

        k1:
            int a = Checker("Add Input: ", "Input should be a whole number, please add another one");
            string aStr = a.ToString();
            if (aStr.Length % 2 != 0)
            {
                Console.WriteLine("The input should have the even number of digits, please, try again.");
                goto k1;
            }
            for (i = 0; i < aStr.Length / 2; i++)
            {
                sum = sum + a % 100;
                a /= 100;

            }
            string resultStr = sum.ToString() + "99";
            int result = int.Parse(resultStr);
            int percentageOfResult = result - result * 18 / 100;
            Console.WriteLine($"The sum of those double groups is {sum}");
            Console.WriteLine($"The result is {result}");
            Console.WriteLine($"The answer is {percentageOfResult}");
        }

        void Task5E12()
        {
            /*12) 2 dene 5 reqemli eded daxil et.
            I ededin reqemleri ceminin usutne
            II ededin reqemleri hasilini gel.
            Neticenin axirina I ededin en axiinci reqemini artir.*/

            int firstInput = Checker("Add input for first number: ", "First input should be a whole number, please add another one");
            int secondInput = Checker("Add input for second number: ", "Second input should be a whole number, please add another one");
            int[] resultArrayForFirstNumber = SeparateDigitsAndAddToArray(firstInput);
            int[] resultArrayForSecondNumber = SeparateDigitsAndAddToArray(secondInput);

            int sum = 0, product = 1;
            foreach (int i in resultArrayForFirstNumber)
            {
                sum += i;
            }
            foreach (int i in resultArrayForSecondNumber) { product *= i; }

            int result = sum + product;
            int lastDigitOfFirstInput = firstInput % 10;
            string answerStr = result.ToString() + lastDigitOfFirstInput.ToString();
            int answer = int.Parse(answerStr);

            //The rest is for Printing the numbers
            Console.WriteLine($"The inputs are {firstInput} & {secondInput}");
            Console.WriteLine($"The sum of digits of {firstInput} is {sum}");
            Console.WriteLine($"The product of digits of {secondInput} is {product}");
            Console.WriteLine($"The sum of {sum} and {product} is equal to {result}");
            Console.WriteLine($"And, finally, the required answer is {answer}");
        }

        void Task5E13()
        {
            /*13) 3 dene 5 reqemli eded var.
            Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.*/

            int firstInput = Checker("Add Input: ", "Input should be a whole number, please add another one"); //34567
            int secondInput = Checker("Add Input: ", "Input should be a whole number, please add another one");
            int thirdInput = Checker("Add Input: ", "Input should be a whole number, please add another one");

            /* The process is described below with the example above
             * firstInput.ToString() => 34567 is converted to string "34567"
             * firstInput.ToString().Length-1 => In order to find "3" we need to divide it by 10000
             * Math.Pow(10, firstInput.ToString().Length-1) => 10^4 = 10000
             * firstInput / Convert.ToInt32(Math.Pow(10, firstInput.ToString().Length-1))) => Division is done to find the first digit //3
             * (firstInput / Convert.ToInt32(Math.Pow(10, firstInput.ToString().Length-1))).ToString() => It is converted to string so that we can combine first digit with the last digit
             * (firstInput % 10) => //7
             * (firstInput % 10).ToString() => is done to convert last digit to string
             * (firstInput / Convert.ToInt32(Math.Pow(10, firstInput.ToString().Length-1))).ToString() + (firstInput % 10).ToString()) => Done to combine 3 and 7 as string
             * And lastly, int.Parse converts whole thing to integer so that we can do calculation on the combination //37 as integer
             */

            int newNumberOutOfFirstInput = int.Parse((firstInput / Convert.ToInt32(Math.Pow(10, firstInput.ToString().Length - 1))).ToString() + (firstInput % 10).ToString());
            int newNumberOutOfSecondInput = int.Parse((secondInput / Convert.ToInt32(Math.Pow(10, secondInput.ToString().Length - 1))).ToString() + (secondInput % 10).ToString());
            int newNumberOutOfThirdInput = int.Parse((thirdInput / Convert.ToInt32(Math.Pow(10, thirdInput.ToString().Length - 1))).ToString() + (thirdInput % 10).ToString());
            int halfwayResult = newNumberOutOfFirstInput + newNumberOutOfSecondInput + newNumberOutOfThirdInput;
            int result = halfwayResult * 50 / 100;
            int answer = halfwayResult + result;

            //For Printing numbers
            Console.WriteLine($"The given numbers are {firstInput}, {secondInput} and {thirdInput}");
            Console.WriteLine($"The combinations from the first and last digit of the numbers are {newNumberOutOfFirstInput}, {newNumberOutOfSecondInput} and {newNumberOutOfThirdInput}");
            Console.WriteLine($"The sum of those combinations is {halfwayResult}");
            Console.WriteLine($"The required answer is {answer}");
        }

        void Task5E14()
        {
            /* 14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
             6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
             Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
             Alinan cavabdan cix 7 reqemli ededin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
             Neticenin 60 % tap.Cavabin axirina 60 artir.
             Neticeden 18 % cix.*/

            var backupColor = Console.ForegroundColor;
            //4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            int firstInput = Checker("Add Input: ", "Input should be a whole number, please add another one");
            int secondInput = Checker("Add Input: ", "Input should be a whole number, please add another one");
            int thirdInput = Checker("Add Input: ", "Input should be a whole number, please add another one");
            int fourthInput = Checker("Add Input: ", "Input should be a whole number, please add another one");

            int newNumberOutOfFirstInput = firstInput / Convert.ToInt32(Math.Pow(10, firstInput.ToString().Length - 3)); //6 reqemli ededlerin her birinin ilk 3 reqemi
            int newNumberOutOfSecondInput = secondInput / Convert.ToInt32(Math.Pow(10, secondInput.ToString().Length - 3)); //6 reqemli ededlerin her birinin ilk 3 reqemi
            int newNumberOutOfThirdInput = thirdInput / Convert.ToInt32(Math.Pow(10, thirdInput.ToString().Length - 3)); //6 reqemli ededlerin her birinin ilk 3 reqemi

            int sumOfFirstThreeNumbers = newNumberOutOfFirstInput + newNumberOutOfSecondInput + newNumberOutOfThirdInput; //6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            int lastFourDigitsOfFourthNumber = fourthInput % Convert.ToInt32(Math.Pow(10, 4)); //7 reqemli ededin son 4 reqemi
            int halfwayResult = sumOfFirstThreeNumbers + lastFourDigitsOfFourthNumber; //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel

            int[] arrayOfDigitsOfFourthInput = SeparateDigitsAndAddToArray(fourthInput);
            int productOfFirstThreeDigits = arrayOfDigitsOfFourthInput[0] + arrayOfDigitsOfFourthInput[1] + arrayOfDigitsOfFourthInput[2]; //7 reqemli ededin ilk 3 dene reqeminin bir birine vurulmasi
            double almostResult = halfwayResult - productOfFirstThreeDigits; //Alinan cavabdan cix 7 reqemli ededin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi
            double percentageOfAlmostResult = almostResult * 60 / 100; //Neticenin 60 % tap
            double newIndicator = double.Parse(percentageOfAlmostResult.ToString() + "60"); //Cavabin axirina 60 artir
            double eighteenPercentOfNewIndicator = newIndicator * 10 / 100; //18%
            double answer = newIndicator - eighteenPercentOfNewIndicator; // Neticeden 18 % cix


            //For printing
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Attention! the numbers are calculated in decimals");
            Console.ForegroundColor = backupColor;
            Console.WriteLine($"The given numbers are {firstInput}, {secondInput}, {thirdInput} and {fourthInput}");
            Console.WriteLine($"The sum of combinations of first three digits of {firstInput}, {secondInput},{thirdInput} is {sumOfFirstThreeNumbers}");
            Console.WriteLine($"The required answer is {answer}");
        }

        void Task5E15()
        {
            //       5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.
            //3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            //Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            //Cavabdan 7 reqemli ededin son 5 reqemini cix.
            //Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            //Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            //Cavabin axirina 11 artir.
            //Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            //Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.

            int firstInput = Checker("Add Input: ", "Input should be a whole number, please add another one"); //3-digit
            int secondInput = Checker("Add Input: ", "Input should be a whole number, please add another one"); //3-digit
            int thirdInput = Checker("Add Input: ", "Input should be a whole number, please add another one"); //6-digit
            int fourthInput = Checker("Add Input: ", "Input should be a whole number, please add another one"); //6-digit
            int fifthInput = Checker("Add Input: ", "Input should be a whole number, please add another one"); //7-digit


            int sumOfThreeDigitNumber = firstInput + secondInput; //3 reqemli ededlerin cemini tap
            int squareOfLastThreeDigits = Convert.ToInt32(Math.Pow(sumOfThreeDigitNumber % 100, 2)); //cavabin axirdan 2 denesini kvadratini tap.
            int combinationOfThreeDigitNumbers = int.Parse(firstInput.ToString() + secondInput.ToString()); //3 reqemli ededlerin bir birine yapisdirilmasi

            int halfwayResult = squareOfLastThreeDigits + combinationOfThreeDigitNumbers; //Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededi gel.
            int halfwayResultOnePlus = halfwayResult - fifthInput % Convert.ToInt32(Math.Pow(10, 5)); //Cavabdan 7 reqemli ededin son 5 reqemini cix.

            int sumOfSixDigitNumber = thirdInput + fourthInput; //6 reqemlilerin cemi
            int halfwayResultTwoPlus = halfwayResultOnePlus + sumOfSixDigitNumber % 1000; //Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.


            int[] arrayOfDigitsOfFifthInput = SeparateDigitsAndAddToArray(fifthInput);
            int sumOfDigitsOfFifthInput = 0;
            foreach (var i in arrayOfDigitsOfFifthInput)
            {
                sumOfDigitsOfFifthInput += i;
            }
            int[] arrayOfDigitsOfThatSum = SeparateDigitsAndAddToArray(sumOfDigitsOfFifthInput);
            Array.Reverse(arrayOfDigitsOfThatSum);
            int reversedSumOfDigits = int.Parse(string.Join("", arrayOfDigitsOfThatSum)); //7 reqemli ededin reqemleri ceminin tersi

            int halfwayThreePlus = halfwayResultTwoPlus + reversedSumOfDigits;

            int almostResult = Convert.ToInt32(halfwayThreePlus.ToString() + "11"); //Cavabin axirina 11 artir.
            string fifthNumberStr = fifthInput.ToString();
            string newFullNumberStr = "";
            for (int i = 0; i < fifthNumberStr.Length; i = i + 2)
            {
                newFullNumberStr += fifthNumberStr[i];

            }
            int newFullNumber = int.Parse(newFullNumberStr);
            long almostFinal = newFullNumber - almostResult;
            string stringPart = (almostFinal / 10).ToString() + "88" + Math.Abs((almostFinal % 10)).ToString();
            long answer = Convert.ToInt64(stringPart);


            //Printing the number
            Console.WriteLine($"The inputs are {firstInput}, {secondInput}, {thirdInput}, {fourthInput} and {fifthInput}");
            Console.WriteLine($"The sum of three digits number is {sumOfThreeDigitNumber}");
            Console.WriteLine($"The square of last three digits of {sumOfThreeDigitNumber} is {squareOfLastThreeDigits}");
            Console.WriteLine($"The combination Of Three Digit Numbers is {combinationOfThreeDigitNumbers}");
            Console.WriteLine($"The sum of {squareOfLastThreeDigits} and {combinationOfThreeDigitNumbers} is {halfwayResult}");
            Console.WriteLine($"Subtraction of last 5 digits of {fifthInput} from {halfwayResult} is {halfwayResultOnePlus}");
            Console.WriteLine($"The sum of six digit numbers is {sumOfSixDigitNumber}");
            Console.WriteLine($"The sum of {halfwayResultOnePlus} and last three digit of the sum of six digit numbers is {halfwayResultTwoPlus}");
            Console.WriteLine($"The sum of digits of seven digit number is {sumOfDigitsOfFifthInput}");
            Console.WriteLine($"The reversed of the sum is {reversedSumOfDigits}");
            Console.WriteLine($"Additional 11 at the end: {almostResult}");
            Console.WriteLine($"The combinationation of digits at the even location of fifth number is {newFullNumber} ");
            Console.WriteLine($"The subtraction of {almostResult} from {newFullNumber} is {almostFinal}");
            Console.WriteLine($"The final answer is {answer}");
        }
    }
}