using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Maps
    {
        public string _ID;/*{ get; set; }*/
        public string _Name;/*{ get; set; }*/
        public float _Na {  get; set; }
        public Maps(string id,string name)
        {
        _ID = id;
          _Name = name;
        }
        public Maps()
        {
            
        }
        public string ShowData()
        {
            Console.WriteLine("ID: " + _ID + " /Name: " + _Name + " /InGame: " + UserData._inGame);
            return null;
            
        }

            

    }
}
