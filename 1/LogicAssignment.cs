using System;

namespace Employee_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do {
                Console.WriteLine("Choose an Option: ");
                Console.WriteLine("1: Calculation the income of an employee with an annual salary.");
                Console.WriteLine("2: Calculate if a student passes or fails a course.");
                Console.WriteLine("3: Multiply two numbers.");
                Console.WriteLine("4: Divide two numbers.");
                Console.WriteLine("5: Compare two numbers.");
                Console.WriteLine("6: Determine if a number is odd or even.");
                Console.WriteLine("7: Exit.");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        decimal annualSalary;
                        decimal monthlyPay;
                        decimal monthlyDeduction;
                        decimal monthlySalary;

                        Console.WriteLine("You are running program {0}", option);                    
                        Console.WriteLine("What is the employee's annual salary?");
                        annualSalary = decimal.Parse(Console.ReadLine());
                        monthlyPay = annualSalary / 12;
                        Console.WriteLine("What is the employee's monthly deductions?");
                        monthlyDeduction = decimal.Parse(Console.ReadLine());
                        monthlySalary = monthlyPay - monthlyDeduction;
                        Console.WriteLine("The employee makes ${0} per month", monthlySalary);

                        break;
                    case 2:
                        
                        Console.WriteLine("You are running program {0}", option);

                        double grade = 0;
                        double total = 0;
                        double average = 0;
                        int gradeCounter = 0;
                        Console.Out.WriteLine("Enter first grade");
                        grade = Double.Parse(Console.ReadLine());
                        while (grade != 200)
                        {
                            total = total + grade;
                            gradeCounter++;
                            Console.Out.WriteLine("Enter another grade or enter 200 to end.");
                            grade = Double.Parse(Console.ReadLine());
                        }
                        if (gradeCounter != 0)
                        {
                            average = total / gradeCounter;
                            Console.Out.WriteLine("Grade average is: " + average);
                        }
                        else
                        {
                            Console.Out.WriteLine("No grades were entered.");
                        }
                        if (average > 70)
                        {
                            Console.WriteLine("Student Passed the Course!");
                        }
                        else
                        {
                            Console.WriteLine("The Student failed the course...");
                        }

                        break;
                    case 3:
                        Console.WriteLine("You are running program {0}", option);
                        double number1 = 0;
                        double number2 = 0;
                        double result = 0;

                        Console.WriteLine("Enter value for number 1:");
                        number1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter value for number 2:");
                        number2 = Double.Parse(Console.ReadLine());

                        if (number1 == 0 || number2 == 0)
                        {
                            Console.WriteLine("The answer is 0");
                        }
                        else
                        {
                        result = number1 * number2;
                        Console.WriteLine("The result is {0}", result);
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("You are running program {0}", option);

                        Console.WriteLine("Enter value for number 1:");
                        number1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter value for number 2:");
                        number2 = Double.Parse(Console.ReadLine());

                        if (number2 == 0)
                        {
                            Console.WriteLine("You cannot divide by 0.");
                        }
                        else
                        {
                            result = number1 / number2;
                            Console.WriteLine("The result is {0}", result);
                        }

                        break;
                    case 5:
                        Console.WriteLine("You are running program {0}", option);

                        Console.WriteLine("Enter value for number 1:");
                        number1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter value for number 2:");
                        number2 = Double.Parse(Console.ReadLine());

                        if (number1 > number2)
                        {
                            Console.WriteLine("The larger number is {0}.", number1);
                        }
                        else if (number2 > number1)
                        {
                            Console.WriteLine("The larger number is {0}.", number2);
                        }
                        else
                        {
                            Console.WriteLine("The numbers are equal.");
                        }


                        break;
                    case 6:
                        Console.WriteLine("You are running program {0}", option);

                        int myNumber = 0;
                        int myResult = 0;
                        Console.WriteLine("Enter a number:");
                        myNumber = int.Parse(Console.ReadLine());

                        myResult = myNumber % 2;

                        if (myResult == 0)
                        {
                            Console.WriteLine("The number is even.");
                        }
                        else
                        {
                            Console.WriteLine("The number is odd.");
                        }

                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("There is no such program.");
                        break;
                }
            } while (flag);

            //Console.ReadKey();
        }
    }
}
