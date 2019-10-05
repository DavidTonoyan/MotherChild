
using System;

namespace MotherChild
{
    public class Program
    {
        static void Main(string[] args)
        {

           
            Mother Ani = new Mother();
            Child Sahak = new Child();

           Sahak.cry(Sahak);
           Ani.MustSuckle(Sahak);
           Ani.Suckle(Sahak);
           Sahak.Happy();
            


        }
    }
}

