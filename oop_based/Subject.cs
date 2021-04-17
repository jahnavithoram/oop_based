using System;
using System.Collections.Generic;
using System.Text;

namespace oop_based.ss
{
    class Subject
    {
        internal struct Data
        {
            internal string SName;
            internal string Code;
            internal string TName;
        }
        public static List<Data> data = new List<Data>();
        public  void ADD_data(string SName, string Code, string TName)
        {
            Data d;
            d.SName = SName;
            d.Code = Code;
            d.TName = TName;
            data.Add(d);
        }
        public void show_data()
        {
            foreach (Data var in data)
            {
                Console.WriteLine("Sub Name:{0} code:{1} taught by {2} ", var.SName, var.Code, var.TName);
            }
        }
    }
}
