using System;

    public static class Methods
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        public static void Main1()
        {
            MyMethod();
    }

    static void MyMethod2()
    {
        Console.WriteLine("This is method");
    }
    public static void Main2()
    {
        MyMethod2();
    }
}

