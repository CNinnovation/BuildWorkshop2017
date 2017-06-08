using System;
using TheCoolestMVVM;

namespace ConsoleApp1
{
    public class Test : BindableBase
    {
        private string _sample1;

        public string Sample1
        {
            get => _sample1;
            set => SetProperty(ref _sample1, value);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var t1 = new Test { Sample1 = "abc" };
            Console.WriteLine(t1.Sample1);
        }
    }
}
