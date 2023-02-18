
//CLASS AND OBJECT
namespace hello
{
    public class program
    {
        string name;
        int age;
        static void Main(string[] args)
        {
            program obj = new program();
            obj.name = "diwakar";

            obj.age = 24;
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);

        }
    }


}

//ADD TOW NUM
using System;

public class addtwonum
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("enter value 1=");
        num1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("enter value 2=");
        num2 = Convert.ToInt32(Console.ReadLine());

        int result = num1 + num2;
        Console.WriteLine("the value is{0}", result);
    }
}

//conditional statements

//if 
using System;

public class addtwonum
{
    static void Main(string[] args)
    {
        int num1;

        Console.WriteLine("enter value =");
        num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.WriteLine("this is even");
        }
        if (num1 % 2 > 0)
        {
            Console.WriteLine("this is odd");
        }

    }
}

//if else
using System;

public class addtwonum
{
    static void Main(string[] args)
    {
        int num1;

        Console.WriteLine("enter value =");
        num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.WriteLine("this is even");
        }
        else
        {
            Console.WriteLine("this is odd");
        }

    }
}


//else if
using System;

public class addtwonum
{
    static void Main(string[] args)
    {
        int percentge;

        Console.WriteLine("enter value =");
        percentge = Convert.ToInt32(Console.ReadLine());

        if (percentge >= 90)
        {
            Console.WriteLine("this is S grade");
        }
        else if (percentge >= 80)
        {
            Console.WriteLine("this is A grade");
        }
        else if (percentge >= 70)
        {
            Console.WriteLine("this is B grade");
        }
        else if (percentge >= 60)
        {
            Console.WriteLine("this is C grade");
        }
        else if (percentge >= 50)
        {
            Console.WriteLine("this is D grade");
        }
        else
        {
            Console.WriteLine("FAIL");
        }
    }
}


//switch
using System;

public class addtwonum
{
    static void Main(string[] args)
    {
        char ch;

        Console.WriteLine("enter value =");
        ch = Convert.ToChar(Console.ReadLine());

        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':

                Console.WriteLine("is a vowel");
                break;
            default:
                Console.WriteLine("Not vowel");
                break;
        }
    }
}
