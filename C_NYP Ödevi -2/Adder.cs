using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NYP_Ödevi__2
{
    public class Adder : Operator
    {
        public Adder()
        {
            Sembol = "+";
        }
        public override Operand Hesapla(Operand a, Operand b)
        {
            return new Operand(a.Value + b.Value);
        }
    }
}
