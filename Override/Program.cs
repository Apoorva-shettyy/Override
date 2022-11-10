using System;
namespace Program
{
    public class Parent
    {
        public virtual void place()
        {
            Console.WriteLine("KAASHI");
        }
        public virtual void travell()
        {
            Console.WriteLine("BUS");
        }
    }
    public class Child : Parent
    {

        public override void place()
        {
            Console.WriteLine("GOA");
        }
        public override void travell()
        {
            Console.WriteLine("TRAIN");
        }
    }
    class main
    {
        public static void Main()
        {
            //Parent p = new Parent();
            Parent c = new Child();


            c.travell();
            c.place();
        }

    }
}