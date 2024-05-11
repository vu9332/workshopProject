using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
   public static class UserData
    {
        
        public static string ID {  get; set; }
        public static string userName { get; set; }
        public static float health {  get; set; }  
        public static int Point { get; set; }
        public static string _inGame = "Liên Minh Huyền Thoại";

       public static void _UserData()
        {
            Console.Write("Nhập ID: ");
            ID=Console.ReadLine();
            Console.Write("Nhập user name: ");
            userName = Console.ReadLine();
            Console.Write("Nhập health: ");
            health=float.Parse(Console.ReadLine());
            Console.Write("Nhập Point: ");
            Point=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------");
            _ShowData();
            

        }
        public static void _ShowData()
        {
            Console.WriteLine("ID: "+ID);
            Console.WriteLine("User Name: "+userName);
            Console.WriteLine("Máu: "+health);
            Console.WriteLine("Point: "+Point);
        }
       
    }
}
