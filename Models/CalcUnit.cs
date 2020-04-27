using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebL_1.Models
{
//    [BindProperties(SupportsGet = true)]
    public class CalcUnit
    {
        public int a { get; set; }
        public int b { get; set; }
        public CalcUnit(int _a,int _b)
        {

            a = _a;
            b = _b;
        }
        public CalcUnit() { }
        public int Sum() { return a + b; }
        public int Min() { return a - b; }
        public int Mult() { return a * b; }
        public int Div()
        {
            try { return a / b; }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by Zero. Operands reversed.");
                //throw ("Division by zero",e);
                return 0;
            }
        }
        public int Action(int type)
        {
            switch (type)
            {
                case 0: return Sum();
                case 1: return Min();
                case 2: return Mult();
                case 3: return Div();
                default: return 0;
            }
        }
    }

}
