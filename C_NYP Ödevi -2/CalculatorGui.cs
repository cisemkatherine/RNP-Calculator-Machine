using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NYP_Ödevi__2
{
    public class CalculatorGui
    {
        private Calculator calculator;

        public void Start()
        {
            calculator = new Calculator(this);

            Console.WriteLine("İşlemi girin (girdiğiniz sayı ve operatörler arasına boşluk koyun: '2 8 +' gibi), çıkmak için 'kapat' yazın.");

            while (true)
            {
                Console.Write("işlem -> ");
                string input = GetInput();

                if (input.Trim().ToLower() == "kapat")
                    break;

                try
                {
                    calculator.GirdiyiHesapla(input);
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }

            Console.WriteLine("Programı kapatıyorsunuz.");
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void SonucuGoster(double sonuc)
        {
            Console.WriteLine($"Sonuç: {sonuc}");
        }

        public void ShowError(string message)
        {
            Console.WriteLine($"HATA: {message}");
        }
    }
}
