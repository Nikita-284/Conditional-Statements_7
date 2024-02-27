/*
Author: Clinton Daniel
Date: 1/5/2019
Comments: This C# Console application code demonstrates the use of 
conditional statements after getting input from users
*/

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        decimal income = 10000.45M;
        decimal taxRate = 0.1M;
        decimal taxLiability = income * taxRate;
        Debug.WriteLine("Tax liability is " + taxLiability);

        //if statement
        if (income < 400000)
        {
            taxLiability = 0;
        }
        else
        {
            taxRate = 0.5M;
            taxLiability = taxRate * income;
        }
        Debug.WriteLine("Tax liability is " + taxLiability);

        //while loop
        //area of triangle
        /*double area = 0;

        bool stopProgram = false;
        while (stopProgram == false)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 24;
            int c = 25;

            float s = (a + b + c) / 2;

            if (a > 0)
            {
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
            
            else
            {
                stopProgram = true;
            }
            Console.WriteLine("Area of triangle is " +  area);
        } // end while loop
        */

       

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        double area = AreaofTriangle(a, b, c);
        Debug.WriteLine("Area of traingle is " + area);

    }
    // method
    private static double AreaofTriangle(int x, int y, int z)
    {
        float s = (x + y + z) / 2;
        double result = Math.Sqrt(s * (s - x) * (s - y) * (s - z));
        return result;
    }
}


    
