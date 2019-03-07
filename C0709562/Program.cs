using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{

    class Program

    {

        static void Main(string[] args)

        {

            //Student name Sukhraj Singh Student ID C0709562

            //CSD3354 Section2

            //Assignment 2

            //March 7,2019

        }

    }

}



public class DelegateExercises

{

    public delegate void MyDelegate();



    void Method1()

    {

        Console.WriteLine("Method1");

        Console.ReadLine();



    }



    public void Method2()

    {

        MyDelegate myDelegate = new MyDelegate(Method1);

        myDelegate();



    }

}



namespace DelegatesAndEvents

{

    class Program

    {

        static void Main(string[] args)

        {

            // TO DO: Call Method2 from the DelegateExercises Class

        }

    }

}