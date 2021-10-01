using System;

namespace HomeworkBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTask();
            //SecondTask();
            //ThirdTask();
            //FourthTask();
            FifthTask();
        }

        /// <summary>
        /// Пользователь вводит 2 числа(A и B). Если A>B, подсчитать A+B, если A = B, подсчитать A* B, если A меньше B, подсчитать A-B.
        /// </summary>
        static void FirstTask()
        {
            Console.WriteLine("Enter number A:");
            double numberA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number B:");
            double numberB = Convert.ToDouble(Console.ReadLine());

            double calculationResult;
            string calculationTemplate;
            if (numberA > numberB)
            {
                calculationResult = numberA + numberB;
                calculationTemplate = "A + B";
            }
            else if (numberA == numberB)
            {
                calculationResult = numberA * numberB;
                calculationTemplate = "A * B";
            }
            else
            {
                calculationResult = numberA - numberB;
                calculationTemplate = "A - B";
            }

            Console.WriteLine($"Calculation is on template: \"{calculationTemplate}\" and result is: {calculationResult}");

        }


        /// <summary>
        /// Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами(X, Y).
        /// </summary>
        static void SecondTask()
        {
            Console.WriteLine("Enter X coordinate:");
            int xCoordinate = Convert.ToInt32(Console.ReadLine());

            if (xCoordinate == 0)
            {
                Console.WriteLine("Your point is on Ox axis. It is impossible to determine the quarter. Enter another value in next time. Bye bye:)");
                return;
            }

            Console.WriteLine("Enter Y coordinate:");
            int yCoordinate = Convert.ToInt32(Console.ReadLine());

            if (yCoordinate == 0)
            {
                Console.WriteLine("Your point is on Oy axis. It is impossible to determine the quarter. Enter another value in next time. Bye bye:)");
                return;
            }

            if (xCoordinate > 0)
            {
                if (yCoordinate > 0)
                {
                    Console.WriteLine("Your point is on First quarter.");
                    return;
                }

                Console.WriteLine("Your point is on Fourth quarter.");
                return;
            }

            if (yCoordinate > 0)
            {
                Console.WriteLine("Your point is on Second quarter.");
                return;
            }

            Console.WriteLine("Your point is on Third quarter.");

        }


        /// <summary>
        /// Пользователь вводит 3 числа(A, B и С). Выведите их в консоль в порядке возрастания.
        /// </summary>
        static void ThirdTask()
        {
            Console.WriteLine("Enter number A:");
            double numberA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number B:");
            double numberB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number C:");
            double numberC = Convert.ToDouble(Console.ReadLine());


            if (numberA >= numberB)
            {
                if (numberB >= numberC)
                {
                    Console.WriteLine($"{numberC} {numberB} {numberA}");
                }
                else if (numberA >= numberC)
                {

                    Console.WriteLine($"{numberB} {numberC} {numberA}");
                }
                else
                {
                    Console.WriteLine($"{numberB} {numberA} {numberC}");
                }
            }
            else
            {
                if (numberA >= numberC)
                {
                    Console.WriteLine($"{numberC} {numberA} {numberB}");
                }
                else if (numberC >= numberB)
                {
                    Console.WriteLine($"{numberA} {numberB} {numberC}");
                }
                else
                {
                    Console.WriteLine($"{numberA} {numberC} {numberB}");
                }
            }
        }

        /// <summary>
        /// Пользователь вводит 3 числа(A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.
        /// </summary>
        static void FourthTask()
        {
            Console.WriteLine("Enter number A:");
            double numberA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number B:");
            double numberB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number C:");
            double numberC = Convert.ToDouble(Console.ReadLine());

            double discriminant = Math.Pow(numberB, 2) - 4 * numberA * numberC;

            if (discriminant > 0)
            {
                Console.WriteLine("Discriminant is grater than 0, so we have two roots:");
                double firstRoot = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA);
                double secondRoot = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
                Console.WriteLine($"First root (X1) is: {firstRoot}  Second root (X2) is: {secondRoot}");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("Discriminant is equal to 0, so we have only one root:");
                double root = (-numberB) / (2 * numberA);
                Console.WriteLine($"Root of X is: {root}");
            }
            else
            {
                Console.WriteLine("Discriminant is less than 0, so we haven't any real roots.");
            }

        }

        /// <summary>
        /// Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        /// </summary>
        static void FifthTask()
        {
            Console.WriteLine("Enter 2-digits number:");
            int numberToTranscription = Convert.ToInt32(Console.ReadLine());

            if (numberToTranscription > 99 || numberToTranscription < 10)
            {
                Console.WriteLine("This number is not valid.");
                return;
            }

            string resultTranscriptionString = string.Empty;
            if (numberToTranscription < 20)
            {
                resultTranscriptionString = numberToTranscription switch
                {
                    11 => "Одиннадцать",
                    12 => "Двенадцать",
                    13 => "Тринадцать",
                    14 => "Четырнадцать",
                    15 => "Пятнадцать",
                    16 => "Шестнадцать",
                    17 => "Семнадцать",
                    18 => "Восемнадцать",
                    19 => "Девятнцать",
                    _ => "Not valid number, something get wrong."
                };
                Console.WriteLine($"Your number transcription is: {resultTranscriptionString}");
                return;
            }

            int secondDigit = numberToTranscription / 10;
            int firstDigit = numberToTranscription % 10;

            string secondDigitTranscription;
            string firstDigitTranscription;

            secondDigitTranscription = secondDigit switch
            {
                2 => "Двадцать",
                3 => "Тридцать",
                4 => "Сорок",
                5 => "Пятьдесят",
                6 => "Шестьдесят",
                7 => "Семьдесят",
                8 => "Восемьдесят",
                9 => "Девяносто",
                _ => "Not valid number, something get wrong."
            };

            firstDigitTranscription = firstDigit switch
            {
                0 => string.Empty,
                1 => "один",
                2 => "два",
                3 => "три",
                4 => "четыре",
                5 => "пять",
                6 => "шесть",
                7 => "семь",
                8 => "восемь",
                9 => "девять",
                _ => "Not valid number, something get wrong."
            };

            resultTranscriptionString = $"{secondDigitTranscription} {firstDigitTranscription}".Trim();

            Console.WriteLine($"Transcription of your digits is: {resultTranscriptionString}");
        }



    }
}
