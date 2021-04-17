using System;
using System.Collections.Generic;
using System.Text;

namespace oop_based.ss
{
    
    class GetData { 
        public struct Data
        {
            public string Name;
            public string Class;
        }
        public  List<Data> data =new List<Data>();
        public  void ADD_data(string Name, string Class)
        {
            Data d;
            d.Name = Name;
            d.Class = Class;
            data.Add(d);
        }
        public void show_data()
        {
            foreach(Data var in data)
            {
                Console.WriteLine("Name:{0} belongs to Class:{1}", var.Name, var.Class);
            }
        }
    }
}
