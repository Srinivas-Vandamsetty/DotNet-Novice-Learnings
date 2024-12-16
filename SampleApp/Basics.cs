using System;
using System.ComponentModel.Design;



public static class Basics
{


    //If Else Condition and Switch case.

    /*    public static void IfElse()
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are minor");
            }
            else if (age > 18 && age < 60)
            {
                Console.WriteLine("You are major");
            }
            else
            {
                Console.WriteLine("You are senior citizen");
            }

        }*/

    /* public static void Switch()
     {
         Console.WriteLine("Enter a number between 1 and 5:");
         int number = Convert.ToInt32(Console.ReadLine());

         switch (number)
         {
             case 1:
                 Console.WriteLine("You selected One.");
                 break;

             case 2:
                 Console.WriteLine("You selected Two.");
                 break;

             case 3:
                 Console.WriteLine("You selected Three.");
                 break;

             case 4:
                 Console.WriteLine("You selected Four.");
                 break;

             case 5:
                 Console.WriteLine("You selected Five.");
                 break;

             default:
                 Console.WriteLine("Invalid selection. Please enter a number between 1 and 5.");
                 break;
         }
     }*/

 

    //For Loop.

    public static void ForLoop()
    {
        for (int i = 1; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }

    public static void ForLoop1()
    {
        for (int i = 2; i < 16; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }

    //Arrays.
    public static void Arrays()
    {
        int[] EvenNumbers = new int[5];
        EvenNumbers[0] = 2;
        EvenNumbers[1] = 4;
        EvenNumbers[2] = 6;
        EvenNumbers[3] = 8;
        EvenNumbers[4] = 10;

        Console.WriteLine(EvenNumbers[3]);

    }

    public static void Array1()
    {
        int[] OddNumbers = [1, 3, 5, 7, 9];
        Console.WriteLine(OddNumbers[3]);
    }

    public static void Array2()
    {
        //Change the array element.
        string[] bikes = { "Enfield", "Yamaha", "Bajaj", "Honda"  };

        bikes[2] = "Hero";
        Console.WriteLine(bikes[2]);
    }


    //For Each Loop.

    public static void ForEach()
    {
        string[] cars = { "Tata", "Toyota", "Mahindra", "Honda", "Suzuki" };
        int[] EvenNumbers = [2, 4, 6, 8, 10 ];

        foreach(string car in cars)
        {
            Console.WriteLine(car);
        }

        foreach(int even in EvenNumbers)
        {
            Console.WriteLine(even);
        }

    }

    public static void ArraySort()
    {
        string[] Names = { "Sai", "Rajesh", "Akash", "Nagendra", "Praveen" };
        Array.Sort(Names);

        foreach (string i in Names)
            Console.WriteLine(i);


        int[] numbers = [5, 6, 7, 2, 4, 1, 3, 10];
         Array.Sort(numbers);

        foreach (int j in numbers)
        {
            Console.WriteLine(j);
        }

    }


}


