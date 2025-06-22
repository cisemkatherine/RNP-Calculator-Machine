using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NYP_Ödevi__2
{
    public class Divider : Operator
    {
        public Divider()
        {
            Sembol = "/";
        }
        public override Operand Hesapla(Operand a, Operand b)
        {
            if (b.Value == 0)
                throw new DivideByZeroException("Sıfıra bölme hatası.");
            return new Operand(a.Value / b.Value);
        }
    }
}
