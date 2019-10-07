using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        User t = new User() { ID = 2, Name = "HH", Money = 10000 };

        Console.WriteLine("ID:" + t.ID + " Name:" + t.Name + " Money:" + t.Money);

        string msg = t.Ser();

        Console.WriteLine("msg:" + msg);

        msg.DeSer(out User t2);

        Console.WriteLine("ID:" + t2.ID + " Name:" + t2.Name + " Money:" + t2.Money);

        Console.ReadKey();
    }

}

