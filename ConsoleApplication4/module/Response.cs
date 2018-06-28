using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.module
{
    public enum Status
    {
        ok, error
    }
    public class Response
    {
        public void getInfo()
        {
            Console.WriteLine(status);
            if (status == Status.ok)
                Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(status);

        }
        public Status status { get; set; }
        public string Error { get; set; }
    }


}
