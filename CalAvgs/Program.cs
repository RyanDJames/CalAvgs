using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalAvgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the four operations using 1 through 4." +
                "\nOption 1, Sum of 10 test scores:" +
                "\nOption 2, Average of 10 test scores:" +
                "\nOption 3, Average specific number of test scores:" +
                "\nOption 4, Average of non specific number of test scores: ");
            string userValue = (Console.ReadLine());
            if (userValue == "1")
            {
                double[] numbers = new double[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Please enter 10 digits between 0 and 100.");
                    Console.WriteLine("Please enter a number: ");
                    double input = Convert.ToDouble(Console.ReadLine());
                    numbers[i] = input;


                }
                double sum = numbers.Sum();
                double count = numbers.Count();
                Console.WriteLine("The sum of the numbers entered is: {0}", sum);
                Console.ReadLine();

            }
            else if (userValue == "2")
            {
                Console.WriteLine("Let's calculate grades of test scores!");


                double[] testScores = new double[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Please enter a test score: ");
                    double input = Convert.ToDouble(Console.ReadLine());
                    testScores[i] = input;

                }
                double average = testScores.Average();



                if (average < 60)
                {
                    string grade = "F+";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is an {1}.", average, grade);
                    Console.Write("The + on the F+ is still an F, but it makes the F look more positive!");
                }
                else if (average <= 69.99 && average >= 60)
                {
                    string grade = "D";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is a {1}.", average, grade);
                }
                else if (average <= 79.99 && average >= 70)
                {
                    string grade = "C";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is a {1}.", average, grade);
                }
                else if (average <= 89.99 && average >= 80)
                {
                    string grade = "B";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is a {1}.", average, grade);
                }
                else if (average <= 100 && average >= 90)
                {
                    string grade = "A";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is an {1}.", average, grade);
                    Console.WriteLine("Wow! We've got a little smarty pants!");
                }
                else
                {
                    Console.Write("One of us made a mistake... And I'm a computer");
                    Console.ReadLine();
                }
            }
            else if (userValue == "3")
            {
                Console.WriteLine("Let's calculate grades of test scores!");
                Console.WriteLine("How many tests will we be scored today? ");
                int X = Convert.ToInt32(Console.ReadLine());

                double[] testScores = new double[X];

                for (int i = 0; i < X; i++)
                {
                    Console.WriteLine("Please enter a test score: ");
                    double input = Convert.ToDouble(Console.ReadLine());
                    testScores[i] = input;

                }
                double average = testScores.Average();



                if (average < 60)
                {
                    string grade = "F+";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is an {1}.", average, grade);
                    Console.Write("The + on the F+ is still an F, but it makes the F look more positive!");
                }
                else if (average <= 69.99 && average >= 60)
                {
                    string grade = "D";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is a {1}.", average, grade);
                }
                else if (average <= 79.99 && average >= 70)
                {
                    string grade = "C";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is n {1}.", average, grade);
                }
                else if (average <= 89.99 && average >= 80)
                {
                    string grade = "B";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is a {1}.", average, grade);
                }
                else if (average <= 100 && average >= 90)
                {
                    string grade = "A";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is an {1}.", average, grade);
                    Console.WriteLine("Wow! We've got a little smarty pants!");
                }
                else
                {
                    Console.Write("One of us made a mistake... And I'm a computer");
                    Console.ReadLine();
                }

            }
            else if (userValue == "4")
            {





                List<double> numbers = new List<double>();
                bool attempt = true;
                while (attempt)
                {



                    Console.Write("Please input a grade{0} (type Quit to exit): ", numbers.Count() + 1);
                    string entry = (Console.ReadLine());



                    if (entry == "quit")
                    {
                        attempt = false;

                    }

                    else if (Convert.ToDouble(entry) >= 0 || Convert.ToDouble(entry) <= 100)
                    {


                        numbers.Add(Convert.ToDouble(entry));

                    }


                    else
                        Console.WriteLine("Did not understand.");




                }
                double Avg = numbers.Average();

                if (Avg < 60)
                {
                    string grade = "F+";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is an {1}.", Avg, grade);
                    Console.Write("The + on the F+ is still an F, but it makes the F look more positive!");
                }
                else if (Avg <= 69.99 && Avg >= 60)
                {
                    string grade = "D";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is a {1}.", Avg, grade);
                }
                else if (Avg <= 79.99 && Avg >= 70)
                {
                    string grade = "C";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is a {1}.", Avg, grade);
                }
                else if (Avg <= 89.99 && Avg >= 80)
                {
                    string grade = "B";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is a {1}.", Avg, grade);
                }
                else if (Avg <= 100 && Avg >= 90)
                {
                    string grade = "A";
                    Console.WriteLine("Student's grade average is {0}. Therefore, their grade is an {1}.", Avg, grade);
                    Console.WriteLine("Wow! We've got a little smarty pants!");
                }
                else
                {
                    Console.Write("One of us made a mistake... And I'm a computer");
                    Console.ReadLine();
                }
            }
            else
            {

                Console.Write("Sorry, I didn't understand. Perhaps you're having an aneurysm? I hope not. If you're ok, then maybe try again!");

            }
            Console.ReadLine();
        }

    }
}
