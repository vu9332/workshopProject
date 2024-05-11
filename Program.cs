using System.Net.Http.Headers;

namespace lab1
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.InputEncoding=System.Text.Encoding.UTF8;
            // bài 1
           /* Console.WriteLine("Bài 1");
            UserData._UserData();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // bài 2
            Console.WriteLine("Bài 2.1");
            var map=new Maps(UserData.ID,UserData.userName);
            map.ShowData();
            Console.WriteLine();
            Console.WriteLine("Bài 2.2");
            var map2 = new Maps()
            {
                _ID = UserData.ID,
                _Name=UserData.userName,
            };
            map2.ShowData();
            if (map2._Na == 1)
            { 
                map2._Na = 2;
                Console.WriteLine(map2._Na);


            }*/
                
            Toan tinh = new Toan();
            tinh.nhap();
            Console.WriteLine(tinh.Cong()); 
            Console.WriteLine(tinh.Tru()); 
            Console.WriteLine(tinh.Nhan()); 
            Console.WriteLine(tinh.Chia()); 
          
        

        }
    }
}
