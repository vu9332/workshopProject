using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    partial class Toan
    {
        public float A {  get; set; }
        public float B {  get; private set; }
    }
    partial class Toan 
    {
        public void nhap()
        {
            Console.Write("Số A: ");
            A=float.Parse(Console.ReadLine());  
            Console.Write("Số B: ");
            B = float.Parse(Console.ReadLine());

        }


    }

    partial class Toan
    {
        public float Cong()
        {
            return A + B;
            
        }
    public float Tru()
        {
            return A - B;

        }
    public float Nhan()
        {
            return A * B;
        }
    public float Chia()
        {
            return A + B;
        }
    
    }

}
