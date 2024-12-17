using System;
using SampleApp.C__Basics.Variables;
using SampleApp.C__Basics.Arrays;
using SampleApp.C__Basics.DataTypes;
using SampleApp.C__Basics.ForEach;
using SampleApp.C__Basics.IfElse;
using SampleApp.C__Basics.Operators;
using SampleApp.C__Basics.SwitchCase;
using SampleApp.C__Basics.TypeCasting;
using SampleApp.C__Basics.UserInput;
using SampleApp.Exceptions;
using SampleApp.Oops;
using SampleApp.Oops.Abstraction;
using SampleApp.Oops.Constructor;
using SampleApp.Oops.Encapsulation;
using SampleApp.Oops.Inheritance;
using SampleApp.Oops.Interface;
using SampleApp.Oops.Polymorphism;
using SampleApp.Oops.Properties;
using SampleApp.Oops.Enums;
using SampleApp.C__Basics.Loops;
using SampleApp.Oops.AccessControl;

class Program
{
    static void Main()
    {
        // Creating variables object.
        Console.WriteLine("***** VARIABLES *****");
        VariableExamples variablesObg = new VariableExamples();
        variablesObg.DisplayVariableValues();

        // Creating an object of DataTypeExamples class.
        Console.WriteLine("\n***** DATA TYPES *****");
        DataTypeExamples dataTypeExamplesObj = new DataTypeExamples();
        dataTypeExamplesObj.DisplayDataTypes();

        // Creating an object of OperatorsExamples class.
        Console.WriteLine("\n***** OPERATORS *****");
        OperatorsExamples operatorsExamplesObj = new OperatorsExamples();
        operatorsExamplesObj.DisplayOperators();

        // Creating an object of WhileLoopExamples class.
        Console.WriteLine("\n***** WHILE LOOP *****");
        WhileLoopExamples whileLoopExamplesObj = new WhileLoopExamples();
        whileLoopExamplesObj.DisplayNumbersUpToTen();
        whileLoopExamplesObj.DisplayNumbersWithBreak();
        whileLoopExamplesObj.DisplayNumbersWithContinue();

        // Creating an object of ForLoopExamples class.
        Console.WriteLine("\n***** FOR LOOP *****");
        ForLoopExamples forLoopExamplesObj = new ForLoopExamples();
        forLoopExamplesObj.DisplayNumbersSkippingFive();
        forLoopExamplesObj.DisplayEvenNumbers();

        // Creating an object of TypeCastingExamples class.
        Console.WriteLine("\n***** TYPE CASTING *****");
        TypeCastingExamples typeCastingExamplesObj = new TypeCastingExamples();
        typeCastingExamplesObj.DisplayTypeCastingExamples();

        // Creating an object of SingleDimensionalArrayExamples class.
        Console.WriteLine("\n***** Single Dimensional Array *****");
        SingleDimensionalArrayExamples singleDimensionalArrayExamplesObj = new SingleDimensionalArrayExamples();
        singleDimensionalArrayExamplesObj.DisplayArrayElementAtIndexThree();
        singleDimensionalArrayExamplesObj.DisplayElementAtIndexThree();
        singleDimensionalArrayExamplesObj.ModifyAndDisplayArrayElement();
        singleDimensionalArrayExamplesObj.DisplayArrayElementsWithIndex();

        // Creating an object of MultiDimensionalArrayExamples class.
        Console.WriteLine("\n***** Multi Dimensional Array *****");
        MultiDimensionalArrayExamples multiDimensionalArrayExamplesObj = new MultiDimensionalArrayExamples();
        multiDimensionalArrayExamplesObj.DisplayMatrixElements();

        // Creating an object of ArraySortingExamples class.
        Console.WriteLine("\n***** ARRAY SORT *****");
        ArraySortingExamples arraySortingExamplesObj = new ArraySortingExamples();
        arraySortingExamplesObj.DisplaySortedArrays();

        // Creating an object of ForEachLoopExamples class.
        Console.WriteLine("\n***** For Each Loop Examples *****");
        ForEachLoopExamples forEachLoopExamplesObj = new ForEachLoopExamples();
        forEachLoopExamplesObj.DisplayFruitsUsingForEach();
        forEachLoopExamplesObj.DisplayCarsAndEvenNumbers();

        // Creating an object of UserInputExamples class.
        Console.WriteLine("\n***** User Input Example *****");
        UserInputExamples userInputExamplesObj = new UserInputExamples();
        userInputExamplesObj.CollectAndDisplayUserInput();

        // Creating if-else object.
        Console.WriteLine("\n***** IF-ELSE *****");
        conditionalLogic ifElseClassObj = new conditionalLogic();
        ifElseClassObj.DetermineAgeCategory();

        // Creating number selector object.
        Console.WriteLine("\n***** SWITCH-CASE *****");
        NumberSelectorClass numberSelectorObj = new NumberSelectorClass();
        numberSelectorObj.SelectNumber();


        // Creating an object of PersonDetails and passing values to the constructor
        Console.WriteLine("\n***** Person Details *****");
        PersonDetails personObj = new PersonDetails("Srinu", "Male", 26);
        personObj.ShowDetails();

        // Creating inheritance object.
        Console.WriteLine("\n***** Inheritance *****");
        Employee newEmployeeObj = new Employee(7, "Dhoni", 41, 77777);
        Console.WriteLine(newEmployeeObj.EmpId + newEmployeeObj.EmployeeName + newEmployeeObj.EmployeeAge + newEmployeeObj.EmployeeContact);

        // Encapsulation example
        Console.WriteLine("\n***** Encapsulation *****");
        Person person = new Person("Srinu", 25, "Male", "123 Main Street, City");
        person.DisplayDetails();

        PersonProperties newObj = new PersonProperties();
        newObj.Name = "SaiSrinu";
        Console.WriteLine(newObj.Name);

        // Access Modifiers example
        Console.WriteLine("\n***** Access Modifiers *****");
        CarInformation car = new CarInformation();
        car.DisplayModel();
        car.DisplayColor();
        // car.DisplaySpeed();

        // Polymorphism method overloading.
        Console.WriteLine("\n***** Polymorphism method overloading *****");
        MethodOverloadingClass methodOverloadingClass = new MethodOverloadingClass();
        var add1 = methodOverloadingClass.Add(5, 4);
        Console.WriteLine(add1);
        var add2 = methodOverloadingClass.Add(5, 9, 6);
        Console.WriteLine(add2);
        var add3 = methodOverloadingClass.Add(5, 9, 9, 2);
        Console.WriteLine(add3);

        // Polymorphism method overriding.
        Console.WriteLine("\n***** Polymorphism method overriding *****");
        Animal animal = new Animal();
        animal.animalSound();
        Animal dog = new Dog();
        dog.animalSound();


        // Abstraction Example.
        Console.WriteLine("\n***** Abstraction Example *****");
        // Creating objects of CarAbstraction, BikeAbstraction, and BoatAbstraction.
        VehicleAbstraction myCar = new CarAbstraction();
        VehicleAbstraction myBike = new BikeAbstraction();
        VehicleAbstraction myBoat = new BoatAbstraction();

        // Calling the DisplayInfo method (abstract method implementation).
        myCar.DisplayInfo();
        myBike.DisplayInfo();
        myBoat.DisplayInfo();

        // Calling the Move method (concrete method from the abstract class).
        myCar.Move();
        myBike.Move();
        myBoat.Move();

        // Interface Example.
        Console.WriteLine("\n***** Interface Example *****");
        IAnimal dogObj = new DogInterface();
        IAnimal catObj = new CatInterface();
        dogObj.MakeSound();
        catObj.MakeSound();

        // Exceptions.
        Console.WriteLine("\n***** Exceptions *****");
        ZeroDivisionHandling exceptions = new ZeroDivisionHandling();
        exceptions.ExceptionMethod();

        Console.WriteLine("");
        HandleFileNotFound handleFileNotFound = new HandleFileNotFound();
        handleFileNotFound.HandleFileNotFoundMethod();


        //Enums colors example.
        Console.WriteLine("\n***** Enums Examples *****");
        // Assign an enum value to a variable
        Colors favoriteColor = Colors.Green;
        // Display the enum value
        Console.WriteLine("My favorite color is: " + favoriteColor);
        // Display all available colors
        Console.WriteLine("Available colors:");
        foreach (string color in Enum.GetNames(typeof(Colors)))
        {
            Console.WriteLine(color);
        }

        Console.WriteLine();


        //Enums dates example.

        Console.WriteLine("\n***** Enums Dates Example *****");
        // Assign an enum value to a variable
        DaysOfWeek today = DaysOfWeek.Wednesday;

        // Use the enum in a condition
        if (today == DaysOfWeek.Wednesday)
        {
            Console.WriteLine("It's the middle of the week!");
        }

        // Loop through all enum values
        Console.WriteLine("Days of the week:");
        foreach (string day in Enum.GetNames(typeof(DaysOfWeek)))
        {
            Console.WriteLine(day);
        }

    }
}
