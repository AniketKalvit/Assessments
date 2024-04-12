using System;
namespace Assessments
{
    public class FirstProgram
    {
        // main is not public method
        // Main () M is in capital letter
        static void Main(string[] args)
        {
            int a = 30, b = 20;
           bool result= (a<=b)? true:false;

            Console.WriteLine(result);

            int result2 = (a <= b) ? a : b;
            Console.WriteLine(result2);

            string result3 = (a <= b) ? "a is less than b" : "a is greater than b";
            Console.WriteLine(result3);
            
                      
        }
    }
    
}

namespace Test1
{

    public class A
    {

    }
}

namespace Test2
{

    public class A
    {

    }
}