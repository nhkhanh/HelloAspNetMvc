using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class CalculatorModels
    {
        public int a { get; set; }
        public int b { get; set; }
        public int s { get; set; }

        public int Sum()
        {
            return s = a + b;
        }
    }
}