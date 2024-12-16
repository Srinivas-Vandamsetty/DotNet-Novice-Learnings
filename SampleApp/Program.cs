using System;
using SampleApp.C__Basics.Arrays;
using SampleApp.C__Basics.DataTypes;
using SampleApp.C__Basics.ForEach;
using SampleApp.C__Basics.ForLoop;
using SampleApp.C__Basics.IfElse;
using SampleApp.C__Basics.Operators;
using SampleApp.C__Basics.SwitchCase;
using SampleApp.C__Basics.TypeCasting;
using SampleApp.C__Basics.UserInput;
using SampleApp.C__Basics.WhileLoop;
using SampleApp.Exceptions;
using SampleApp.Oops;
using SampleApp.Oops.Abstraction;
using SampleApp.Oops.Access_modifier;
using SampleApp.Oops.Constructor;
using SampleApp.Oops.Encapsulation;
using SampleApp.Oops.Inheritance;
using SampleApp.Oops.Interface;
using SampleApp.Oops.Polymorphism;
using SampleApp.Oops.Properties;

class Program
{
    static void Main()
    {
        /*        // Creating variables object.
                Console.WriteLine("***** VARIABLES *****");
                Variables variables_obg = new Variables();
                variables_obg.VariablesMethod();

                // Creating data types object.
                Console.WriteLine("\n***** DATA TYPES *****");
                DataTypesClass dataTypes_obj = new DataTypesClass();
                dataTypes_obj.DataTypesMethod();

                // Creating operators object.
                Console.WriteLine("\n***** OPERATORS *****");
                OperatorsClass operatorsClassObj = new OperatorsClass();
                operatorsClassObj.OperatorsMethod();

                // Creating while loop object.
                Console.WriteLine("\n***** WHILE LOOP *****");
                WhileLoopClass whileLoopClassObj = new WhileLoopClass();
                whileLoopClassObj.WhileLoopMethod();
                whileLoopClassObj.While1();
                whileLoopClassObj.While2();

                // Creating for loop object.
                Console.WriteLine("\n***** FOR LOOP *****");
                ForLoopClass forLoopClassObj = new ForLoopClass();
                forLoopClassObj.ForLoopMethod();
                forLoopClassObj.ForLoop1();

                // Creating type casting object.
                Console.WriteLine("\n***** TYPE CASTING *****");
                TypeCasting typecasting_obj = new TypeCasting();
                typecasting_obj.TypeCastingMethod();

                // Creating single dimensional array object.
                Console.WriteLine("\n***** Single Dimensional Array *****");
                SingleArrayClass singleArrayClassObj = new SingleArrayClass();
                singleArrayClassObj.ArrayMethod();
                singleArrayClassObj.Array1();
                singleArrayClassObj.Array2();
                singleArrayClassObj.ArrayLoop();

                // Creating multi dimensional array object.
                Console.WriteLine("\n***** Multi Dimensional Array *****");
                MultiArrayClass multilArrayClassObj = new MultiArrayClass();
                multilArrayClassObj.MultiArrayMethod();

                // Creating  array sort object.
                Console.WriteLine("\n*****Array SORT*****");
                ArraySortClass arraySortObj = new ArraySortClass();
                arraySortObj.ArraySortMethod();

                // Creating for each object.
                Console.WriteLine("\n***** For Each *****");
                ForEachClass forEachClassObj = new ForEachClass();
                forEachClassObj.ForEachMethod();
                forEachClassObj.ForEach1();

                // Creating user input object.
                Console.WriteLine("\n***** USER INPUT *****");
                UserInputClass userInputClassObj = new UserInputClass();
                userInputClassObj.UserInputMethod();

                // Creating if-else object.
                Console.WriteLine("\n***** IF-ELSE *****");
                IfElseClass ifElseClassObj = new IfElseClass();
                ifElseClassObj.IfElseMethod();

                // Creating switch-case object.
                Console.WriteLine("\n***** SWITCH-CASE *****");
                SwitchCaseClass switchCaseObj = new SwitchCaseClass();
                switchCaseObj.SwitchMethod();*/


        /*        // Creating an object of NewConstructor and passing values to the constructor
                Console.WriteLine("\n***** Constructor *****");
                NewConstructor person1 = new NewConstructor("John Doe", "Male", 30);
                person1.DisplayData();

                // Creating inheritance object.
                Console.WriteLine("\n***** Inheritance *****");
                Employee newobj = new Employee(7, "Dhoni", 41, 77777);

                Console.WriteLine(newobj.EmpId + newobj.EmployeeName + newobj.EmployeeAge + newobj.EmployeeContact);

                NewConstructor myobj = new NewConstructor("Srinu", "Male", 26);
                myobj.DisplayData();

                // Encapsulation.
                Console.WriteLine("\n***** Encapsulation *****");
                EncapsulationClass encapsulationClass = new EncapsulationClass();

                encapsulationClass.Names = "Srinu";
                Console.WriteLine(encapsulationClass.Names);

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
                CarAbstraction car = new CarAbstraction();
                car.DisplayInfo();
                BikeAbstraction bike = new BikeAbstraction();
                bike.DisplayInfo();
                BoatAbstraction boat = new BoatAbstraction();
                boat.DisplayInfo();
                Console.WriteLine();

                // Interface Example.
                Console.WriteLine("\n***** Interface Example *****");
                IAnimal dogobj = new DogInterface();
                IAnimal catobj = new CatInterface();
                dogobj.MakeSound();
                catobj.MakeSound();*/

        // Exceptions.
        Console.WriteLine("\n***** Exceptions *****");
        ZeroDivisionHandling exceptions = new ZeroDivisionHandling();
        exceptions.ExceptionMethod();

        Console.WriteLine("");
        HandleFileNotFound handleFileNotFound = new HandleFileNotFound();
        handleFileNotFound.HandleFileNotFoundMethod();



    }
}
