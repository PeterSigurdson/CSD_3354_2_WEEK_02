using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            var mary = new newClass();
            Console.WriteLine( " how many objects : {0}", newClass.reportOnNumberOfObjects() );

            var paul = new newClass();
            Console.WriteLine(" how many objects : {0}", newClass.reportOnNumberOfObjects());

            var peter = new newClass();
            peter.newMethod();
            Console.WriteLine(" how many objects : {0}", newClass.reportOnNumberOfObjects());
            Console.ReadLine();
        }

        public class newClass
        {
            public static int howManyObjects = 0;
            public newClass()
            {
                howManyObjects++;
                Console.WriteLine("In the constructor: Ahhaa!!");
            }

            public void newMethod()
            {
                int I = 0;
                int SUM = 0;

                for (I = 819; I >= 205; I = I - 17)
                {
                    SUM = SUM + I;
                }
                Console.WriteLine(SUM);
                Console.ReadLine();
            }

            public static int reportOnNumberOfObjects()
            {
                return howManyObjects;
            }
        }
    }
}
