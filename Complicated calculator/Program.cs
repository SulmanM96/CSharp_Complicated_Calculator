using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complicated_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what type of calculation do you want?");
            Console.WriteLine("1.Mathematical");
            Console.WriteLine("2.Area of shape");
            Console.Write("Enter Choice(1-2):");

            int options = int.Parse(Console.ReadLine());
            int op1, op2 = 0;
            switch (options)
            {
                case 1:
                    int firstNum;
                    int secondNum;                   //Variables for equation
                    string operation;
                    int answer;

                    Console.Write("Enter the first number: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());

                    //User input for equation
                    Console.Write("Enter your second number: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your operation ( x , / , +, -) ");
                    operation = Console.ReadLine();

                    if (operation == "x")
                    {
                        answer = firstNum * secondNum;
                        Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                        Console.ReadLine();
                    }
                    else if (operation == "/")
                    {
                        answer = firstNum / secondNum;
                        Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                        Console.ReadLine();
                    }
                    //Getting answers
                    else if (operation == "+")
                    {
                        answer = firstNum + secondNum;
                        Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                        Console.ReadLine();
                    }
                    else if (operation == "-")
                    {
                        answer = firstNum - secondNum;
                        Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("incorrect format! try again!");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    {                                            
                                string shape;
                                double radius, area, length, breadth, side;

                                Console.Write("Enter your shape ( c , s , r) ");
                                shape = Console.ReadLine();


                                if (shape == "c")
                                {

                                    Console.WriteLine("Enter Radius: ");
                                    radius = Convert.ToDouble(Console.ReadLine());
                                    area = Math.PI * radius * radius;
                                    Console.WriteLine("Area of circle: " + area);
                                    Console.ReadLine();
                                }
                                else if (shape == "r")
                                {

                                    Console.WriteLine("Enter length of rectangle : ");
                                    length = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Enter breadth of rectangle : ");
                                    breadth = Convert.ToDouble(Console.ReadLine());
                                    area = length * breadth;
                                    Console.WriteLine("Area of rectangle: " + area);
                                    Console.ReadLine();
                                }
                                else if (shape == "s")
                                {
                                    Console.WriteLine("Enter the Length of Side : ");
                                    side = Convert.ToDouble(Console.ReadLine());
                                    area = side * side;
                                    Console.WriteLine("Area of Square: " + area);
                                    Console.ReadLine();
                                }
                                break;

                        }
                    }
                   





            }
        }
    }

