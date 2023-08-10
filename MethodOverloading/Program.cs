namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void Addition(int NumberOne, int NumberTwo) //simple addition method
        {
            int Sum = NumberOne + NumberTwo;
            Console.WriteLine(Sum);
        }
        public static void Addition(int NumberOne, ref int NumberTwo) //here we are overloading with ref key word
        {
            int Sum = NumberOne + NumberTwo;
            Console.WriteLine(Sum);
        }
        public static void Addition(int NumberOne, int NumberTwo, int NumberThree) //simple addition method overloaded
        {
            int Sum = NumberOne + NumberTwo + NumberThree;
            Console.WriteLine(Sum);
        }
    }
}

/*
 
Defination: Two or more than two methods havaing the same name but different parameters is called method overloading
in C#. Method overloading in C# can be performed by changing the number of parameters,data types(int,float) and the 
kind(ref & out) of the parameters.

Note:

It is not possible to overload a function just based on the return type.

Method overloading & Function overloading are same




 */