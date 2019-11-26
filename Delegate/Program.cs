using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        // attributes
        delegate int Arithmetic_Del(int a, int b);
        delegate void Q4_delegate();

        // main method
        static void Main(string[] args)
        {


            // Add Delegate call
            int a = 10, b = 8;
            Arithmetic_Del add_del = new Arithmetic_Del(new Arithm().add);
            //Console.WriteLine("\t1) Delegate methode: ");
            //Console.WriteLine($"\t\t{a} + {b} = {add_del(a, b)}");

            // Sub Delegate call
            Arithmetic_Del sub_del = new Arithmetic_Del(new Arithm().sub);
            //Console.WriteLine($"\t\t{a} - {b} = {sub_del(a, b)}\n");

            Arithmetic_Del del_arrithm_multicast = new Arithmetic_Del(new Arithm().add) + new Arithmetic_Del(new Arithm().sub);
            //Console.WriteLine($"\t\t{a} & {b} = '{del_arrithm_multicast(a, b)}'\n");
            //Console.WriteLine(del_arrithm_multicast(a, b));
            
            // Lambda expression
            int n = 4; 
            //Func <int, int> carre = x => x*x;
            //Console.WriteLine("\t2) Lambda methode: ");
            //Console.WriteLine( $"\t\t{n}² = {carre(4)}\n");

           

            // Anonimous method
            Arithmetic_Del mult_del = delegate (int a, int b)
            {
                return a*b;
            };
            Console.WriteLine("\t3) Anonimous methode: ");
            Console.WriteLine($"\t\t{a} * {b} = {mult_del(a, b)}");


            // Q4
            // Q4 declaration objects
            //createA();
            //A obj_a = new A();
            //B obj_b = new B();


             
            // Q4 declaration simple delegate
            //Q4_delegate simple_q4_Delegate = new Q4_delegate(obj_a.ma);
            //Console.WriteLine("\n\t4) Q4 simple delegate teste: ");
            //simple_q4_Delegate();

            // Q4 declaration simple delegate liste
            //List<Q4_delegate> tableau_simple_q4_Delegates;

            // Q4 declaration simple multicast delegate
            //Q4_delegate simple_q4_Delegate_multicast = new Q4_delegate(obj_a.ma) + new Q4_delegate(obj_b.mb);
            //Console.WriteLine("\n\t5) Q4 simple delegate multicast teste: ");
            //simple_q4_Delegate_multicast();

            //Console.WriteLine("\n\t6) Q4 simple delegate multicast MINUS specific method teste: ");
            //(simple_q4_Delegate_multicast- simple_q4_Delegate)();

            //Console.WriteLine("\n\t7) Q6 dispose object: ");
            //obj_a.ma();
            //obj_b.mb();

           /* obj_a.Dispose();
            GC.Collect();*/
            

           
            //creatUser();
            GC.Collect();
            

           // obj_a.ma();
            //obj_b.mb();
        }
        public static void createA()
        {
            A obj_a = new A();
        }
       public static void creatUser()
        {
            clsDispose_Fin c2 = new clsDispose_Fin();

            //c2.Dispose();
           
            User u = new User();
        }
        class User
        {
            public User()
            {
                Console.WriteLine("NEw user");
            }
            ~User()
            {
                Console.WriteLine("By user");
            }
        }
       

    }
}
    


