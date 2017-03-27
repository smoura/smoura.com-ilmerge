using System;
using System.Globalization;
using System.Threading;
using Framework;
using Framework.Math;
using Framework.Ux;

namespace ILMergeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string cultureCode = "pt-PT";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureCode);

            var foo = new Foo();
            PrintIFoo(foo);

            var goo = new Goo();
            PrintIFoo(goo);

            var woo = new Woo();
            PrintIFoo(woo);

            Console.ReadLine();
        }

        private static void PrintIFoo(IFoo foo)
        {
            Console.WriteLine(foo.GiveMeAFoo());
            foreach (var fooName in foo.GiveMeTwoFoos())
            {
                Console.WriteLine(fooName);
            }
            Console.WriteLine();
        }
    }
}
