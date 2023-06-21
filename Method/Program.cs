using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {


        {
            MyClass myClass = new MyClass(); 
            myClass.MyMethod(10, 20); 
                
            myClass.MyMethod(num1: 30, num2: 40);

                // This is how to prevent the console from closing until a key is pressed
                Console.ReadKey();
            
            } }

        class MyClass 
        { 
            public void MyMethod(int num1, int num2) 
        {
                int result = num1 + 5; Console.WriteLine(num2);

                Console.ReadLine();

        } }

        

       

    }
    }

