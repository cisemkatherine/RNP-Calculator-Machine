using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NYP_Ödevi__2
{
    public abstract class Operator
    {
        public string Sembol { get; protected set; }
        public abstract Operand Hesapla(Operand a, Operand b);
    }
}
