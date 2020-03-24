using static System.Console;

namespace SimpleDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Demo");
            Apple();
        }

        public static void Apple() {
            var foo = "bar";
            System.Console.WriteLine(foo);
        }
    }

#line 20 "/Users/tanay/dev/line-pragma-implementation-repro/About.cs"
    interface Foo{}

    class Bar: Foo{}
}

