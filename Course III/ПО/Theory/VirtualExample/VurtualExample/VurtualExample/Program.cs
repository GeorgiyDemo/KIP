using System;

namespace VurtualExample
{

    public class A
    {
        public int a;
        public A(int a){
            this.a = a; 
        }

        public virtual void ShowString(){
            Console.WriteLine("Метод класса А " + a); 
        } 
         
    }

    class B :  A
    {
        public int b;

        public B(int b, int a): base(a){
            this.b = b;
       }

        public override void ShowString(){
            Console.WriteLine("Метод класса B "+ b); 
        }

    }

     class C : A
    {
        public int c;

        public C(int c, int a) : base(a){
            this.c = c;

        }
        public new void ShowString(){
            Console.WriteLine("Метод класса C " + c); 
        } 

    }  

    class Program
    {

        static void Main(string[] args)
        {
            A a_obj = new A(2);
            a_obj.ShowString();

            B b_obj = new B(3,2);
            b_obj.ShowString();

            C c_obj = new C(4,2);
            c_obj.ShowString();
        }
    
    }
}
