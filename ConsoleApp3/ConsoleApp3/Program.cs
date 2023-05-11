using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question One
             double Base, Height;
             Console.WriteLine("Calculate The Area Of The Triangle ");
             Base= Convert.ToDouble(Console.ReadLine());
             Height= Convert.ToDouble(Console.ReadLine());
             double Result = 0.5 * Base * Height;
             Console.WriteLine("The Result Is :"+ Result);
            
            //Qestion Two
             Console.Write("Enter The Number :");
             int num1 = Convert.ToInt32(Console.ReadLine());
             if (num1 >=1)
             {
                 Console.WriteLine("This Is Number Positive !! ");

             }
             else if(num1 ==0)
             {
                 Console.WriteLine("This Is Zero !!");
             }
             else
             {
                 Console.WriteLine("This Is number Negative");
             }

            //Qestion Three
            Console.Write("Enter The Week Number :");
            int Weeek = Convert.ToInt32(Console.ReadLine());
            switch (Weeek)
            {
                case 1:
                    Console.WriteLine("This Is Satur Day");
                    break;
                case 2:
                    Console.WriteLine("This Is Sun Day");
                    break;
                case 3:
                    Console.WriteLine("This Is Mon Day ");
                    break;
                case 4:
                    Console.WriteLine("This Is Tues Day");
                    break;
                case 5:
                    Console.WriteLine("This Is Wednes Day");
                    break;
                case 6:
                    Console.WriteLine("This Is Thurs Day");
                    break;
                case 7:
                    Console.WriteLine("This Is Fri Day ");
                    break;
                default:
                    Console.WriteLine("Only From  1-7  Days Of The Week !!");
                    break;
            }


            //Question 4
            Console.Write("Enter The Height Of The Person :  ");

            Height = Convert.ToDouble(Console.ReadLine());
            if (Height < 150)
            {
                Console.WriteLine("The Person Is Short ");
            }
            else if (Height > 150 && Height < 165)
            {
                Console.WriteLine("The Person Is Average ");
            }
            else if (Height > 165 && Height < 195)
            {
                Console.WriteLine("The Person Is Tall ");
            }
            else
            {
                Console.WriteLine("The Person Is Giant ");


            }
            //Question 5
            
           Console.Write("Enter The X :");
           int x = Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter The Y :");
           int y = Convert.ToInt32(Console.ReadLine());
           if(x>=0 && y>=0)
           {
               Console.WriteLine("In The First Quarter ");
           }
           else if(x<=-1 && y>=0)
           {
               Console.WriteLine("In The Second Quarter ");
           }
           else if(x<=-1 && y>=0)
           {
               Console.WriteLine("In The third Quarter ");
           }
           else if(x>=0 && y<=-1)
           {
               Console.WriteLine("In The Fourth Quarter ");
           }
           else
           {
               Console.WriteLine("The Number Is Erro");
           }
           

            //Question 6
            Console.Write(" Enter The First Number :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Second Number :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if(number1>=0 && number2 >=0)
            {
                Console.WriteLine(number1 +":"+ "\t The First Number Is Positive");
                Console.WriteLine(number2 +":"+"\t The Second Number Is Positive ");
            }
            else if(number1>=0 || number2<-1)
            {
                Console.WriteLine(number1 +":"+"\t The Fisrt Number Is Positive");
                Console.WriteLine(number2 +":"+ "\t The Second Number Is Not Positive ");
            }
            else if(number1<-1 || number2 >=0)
            {
                Console.WriteLine(number1 +":"+ "\t The First Number Is Not Positive");
                Console.WriteLine(number2 +":"+ "\t The Second Number Is Positive ");
            }
            else
            {
                Console.WriteLine(number1+":"+"\tThe First Number Is Negative ");
                Console.WriteLine(number2+":"+"\tThe Second Number Is Negative ");
            }
            if (number1 >=0 && number2 >=0)
            {
                Console.WriteLine(number1 + " And " + number2 + ":" + "\t The Both numbers Is Positive ");
            }
            else
            {
                Console.WriteLine(number1 + " And " + number2 + ":" + "\t One Of The Numbers Is Negative Or Both !!");
            }
            if (number1 > number2)
            {
                Console.WriteLine( number1+":"+"\t The Number One Greater Than Number Two ");
            }
            else if (number1 == number2)
            { 
                Console.WriteLine(  number1+ "="+number2+":"+ "\t The Number One Equal Number Two");
            }
            else
            {
                Console.WriteLine(number2+":"+ "\t The Number Two Greater Than Number One ");
            }
            Console.ReadLine();
        }
    }
}
