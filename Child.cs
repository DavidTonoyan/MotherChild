using System;


namespace MotherChild
{
    public class Child
    {
     


        public bool IsCry { get; set; }
        public string Name { get; set; }
        public void cry(Child child)
        {
            Console.WriteLine("Child is craying");
            this.IsCry = true;
            System.Threading.Thread.Sleep(1500);
        }
        public void Happy()
        {
            Console.WriteLine("Child is happy!!!");
        }
       
    }
}

