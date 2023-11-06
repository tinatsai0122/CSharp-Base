using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_function_basic
{
    public struct Demo
    {
        public int value;

        public void ShowIfEqual5()
        {
            //if (value == 5) Console.WriteLine("Value is Equal to 5!");
            if (value != 5) return;
            Console.WriteLine("Value is Equal to 5!");
        }


    }
}
