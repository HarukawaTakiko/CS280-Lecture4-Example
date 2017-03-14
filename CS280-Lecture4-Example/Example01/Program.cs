using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        private static void Main(string[] args)
        {
            Status response = Status.Success;
            switch (response)
            {
                case Status.Success;
                    //你要寫的程式
                    Console.WriteLine("狀態是成功");
                    Console.WriteLine((int)response);
                    break;

                case Status.Success;
                    //你要寫的程式
                    Console.WriteLine("狀態是成功");
                    Console.WriteLine(response);
                    break;

                case Status.Error;
                    //你要寫的程式
                    Console.WriteLine("狀態不明,所以什麼都不做");
                    Console.WriteLine(response);
                    break;
            }
        }
    }
}
