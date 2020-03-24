using static System.Console;

namespace SimpleDemo
{
    public class About
    {
        public static void Omni()
        {
            System.Console.WriteLine("Demo");
            Apple();
        }

        public static void Apple() {
            var foo = "bar";
            System.Console.WriteLine(foo);
        }
    }


    interface Far{}

    class Car: Far{}
}

