using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
namespace Delegate
{
    class Class1
    {
    }

    public delegate void delg();
    public class A
    {
       
        public A()
        {
            Console.WriteLine("Instance of A cerated");
        }

       


        public void ma()
        {
            Console.WriteLine("ma");
        }
        ~A()
        {
            Console.WriteLine("Instance of A destroyed");
            
        }
    }
    public class B
    {
        public void mb()
        {
            Console.WriteLine("mb");
        }
    }
}
