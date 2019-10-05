using System;


namespace MotherChild
{
    public class Mother
    {
        public bool feed { get; set; }
        public void MustSuckle(Child child)
        {
            Console.WriteLine("The mother must feed the child!");
            this.feed = true;
            System.Threading.Thread.Sleep(2100);

        }
        public void Suckle(Child child)
        {
            if(this.feed==true)
            {
               
                Console.WriteLine("Mother feeds child");
                System.Threading.Thread.Sleep(1800);
            }
        }


        
    }
}
