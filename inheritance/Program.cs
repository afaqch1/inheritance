using System;

namespace inheritance
{
    class Shapes
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
         

        public void details()
        {
            System.Console.WriteLine("I am from shape class... :)");
        }

        public virtual void show()
        {
            System.Console.WriteLine("I am from base class");
        }
    }

    class Circle : Shapes
    {
        int radius;
        public void details()
        {
            System.Console.WriteLine("I am from Circle class... :)");
        }

        public override void show()
        {
            System.Console.WriteLine("I am from derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shapes obj = new Shapes();
            Shapes obj1 = new Circle();

            obj.Color = "red";

            System.Console.WriteLine("///////////////Properties//////////////////////");
            System.Console.WriteLine(obj.Color);


            System.Console.WriteLine("///////////////Inheritance//////////////////////");
            obj.details();
            obj1.details();


            System.Console.WriteLine("///////////////polymorphism//////////////////////");
            obj.show();
            obj1.show();
        }
    }
}
