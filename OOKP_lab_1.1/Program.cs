using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOKP_lab_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();
            test1.Print();
            test2.Print();
            Console.ReadKey();
        }

    }
    class Test1
    {
        public void Print()
        {
            //comment for branch 1
            Console.WriteLine("Hello from class 1");
        }
    }
    class Test2
    {
        public void Print()
        {
            //comment for commit
            Console.WriteLine("Hello from class 2");
        }
    }
}
