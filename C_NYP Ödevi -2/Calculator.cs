using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NYP_Ödevi__2
{
    public class Calculator
    {
        private Stack stack = new Stack();
        private CalculatorGui gui;

        public Calculator(CalculatorGui gui)
        {
            this.gui = gui;
        }

        public void GirdiyiHesapla(string input)
        {
            string[] ifadeler = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var ifade in ifadeler)
                {
                    if (double.TryParse(ifade, out double sayı))
                    {
                        stack.Push(new Operand(sayı));
                    }
                    else
                    {
                        Operator op = GetOperator(ifade);

                        Operand right, left;

                        try
                        {
                            right = stack.Pop();
                            left = stack.Pop();
                        }
                        catch
                        {
                            throw new Exception("Yeterli sayıda sayı bulunamadı.");
                        }

                        Operand islemlerinSonucu = op.Hesapla(left, right);
                        stack.Push(islemlerinSonucu);
                    }
                }

                if (stack.Count != 1)
                {
                    throw new Exception("Girdiğiniz ifade hatalı, fazla sayı veya eksik operatör olabilir.");
                }

                double sonuc = stack.Pop().Value;
                gui.SonucuGoster(sonuc);
            }
            catch (Exception hata)
            {
                LogError(hata.Message);
                gui.ShowError(hata.Message);
            }
        }

        private Operator GetOperator(string sembol)
        {
            switch (sembol)
            {
                case "+":
                    return new Adder();
                case "-":
                    return new Substracter();
                case "*":
                    return new Multiplier();
                case "/":
                    return new Divider();
                default:
                    throw new Exception($"Tanımsız bir operatör girdiniz: {sembol}");
            }
        }

        private void LogError(string message)
        {
            File.AppendAllText("log.txt", $"{message}{Environment.NewLine}");
        }
    }
}
