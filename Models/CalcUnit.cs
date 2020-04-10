using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebL_1.Models
{
    public class CalcUnit : ICalcUnit
    {
        public int a { get; set; }
        public int b { get; set; }
        public CalcUnit()
        {
            Random r = new Random();
            a = r.Next(0, 10);
            b = r.Next(0, 10);
        }
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
        
    }

}
