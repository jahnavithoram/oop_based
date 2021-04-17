using System;
using System.Collections.Generic;
using System.Text;

namespace oop_based.ss
{
    class DoClass:GetData
    {
        
        public static void Addrec()
        {
            string N, C,T;
            Console.WriteLine("Adding Data\n\n");
           
            Subject sub = new Subject();
            GetData sgd = new GetData();
            GetData tgd = new GetData();

            Console.WriteLine("---------------Teacher---------------\n ");
            Console.WriteLine("Records to be added?\n");
            string an = Console.ReadLine();
            int nn = Convert.ToInt32(an);
            for (int i = 0; i < nn; i++)
                {
                    Console.Write("Name: ");
                    N = Console.ReadLine();
                    Console.Write("Class-sec: ");
                    C = Console.ReadLine();
                    tgd.ADD_data(N, C);
                }


            Console.WriteLine("\n---------------Student---------------\n ");
            Console.WriteLine("Records to be added?\n");
             an = Console.ReadLine();
             nn = Convert.ToInt32(an);
            for (int i = 0; i < nn; i++)
                {
                    Console.Write("Name: ");
                    N = Console.ReadLine();
                    Console.Write("Class-sec: ");
                    C = Console.ReadLine();
                    sgd.ADD_data(N, C);
                }


            Console.WriteLine("\n---------------Subjects---------------\n ");
            Console.WriteLine("Records to be added?\n");
            an = Console.ReadLine();
            nn = Convert.ToInt32(an);
            for (int i = 0; i < nn; i++)
                {
                Console.Write("Sub-Name: ");
                N = Console.ReadLine();
                Console.Write("Code: ");
                C = Console.ReadLine();
                Console.Write("Teacher-Name:");
                T = Console.ReadLine();
                    sub.ADD_data(N, C,T);
                }
            Console.WriteLine("Data of Each fields\n\n");
            Console.WriteLine("STUDENT DATA\n");
            sgd.show_data();
            Console.WriteLine("TEACHER DATA\n");
            tgd.show_data();
            Console.WriteLine("TEACHER-SUBJECT DATA\n");
            sub.show_data();

        }
      
        public static void Do()
        {
            string ch="1";
            
                //ch=Console.ReadLine();
               // Console.WriteLine("1.ADD 2.Show 3.Exit");
                Addrec();
               // if (ch == "2")
                //    Showrec();

            }
        }
    }

