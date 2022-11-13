using System;
using System.ComponentModel;

class Welcome1
{
    static void Main ()
    {

        // oddoreven(Int32.Parse(Console.ReadLine()));

        radiustodiameter();
    }


    static void radiustodiameter()
    {
        Console.WriteLine("Welcome to the radius to diameter/area/circumference calculator");
        Console.WriteLine(" ");
 Console.WriteLine("Enter your radius, and I will give you its diameter, its circumference, and its area!");

        int radius = Int32.Parse(Console.ReadLine());

        
        double pi = Math.PI;
        int diameter = (radius * 2);
        double circumference = (pi * diameter);

        double area = (circumference * circumference)/(pi * 4);

        
        Console.WriteLine("diameter: " + diameter);
        Console.WriteLine("circumference: " + circumference);
        Console.WriteLine("area: " + area);
    }




    //static void oddoreven(int input)
    //{


//            if (input % 2 == 0)
//            {

//                console.writeline("this is an even number");

//            }
//            else if (input % 2 == 1)
//{
//    console.writeline("this is an odd number");
//}




//    }


}
