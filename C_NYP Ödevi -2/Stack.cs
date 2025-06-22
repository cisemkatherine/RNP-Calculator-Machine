using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NYP_Ödevi__2
{
    public class Stack
    {
        private List<Operand> operands = new List<Operand>();
        public void Push(Operand operand)
        {
            operands.Add(operand);
        }
        public Operand Pop()
        {
            if (operands.Count == 0)
                throw new InvalidOperationException("Yığın boş, 'Pop' işlemi yapılamaz.");
            Operand last = operands[operands.Count - 1];
            operands.RemoveAt(operands.Count - 1);
            return last;
        }
        public Operand Peek()
        {
            if (operands.Count == 0)
                throw new InvalidOperationException("Yığın boş, 'Peek' işlemi yapılamaz.");

            return operands[operands.Count - 1];
        }
        public int Count => operands.Count;
    }
}
