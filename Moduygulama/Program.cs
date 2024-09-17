using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalan bulma yazılımıza hoşgeldiniz.");
            Console.WriteLine("Bu uygulama Urfhasoft tarafından geliştirilmiştir.");
            Console.Write("Bölünecek sayıyı giriniz: ");
            string bolunen = Console.ReadLine();
            double s1 = Convert.ToDouble(bolunen);
            Console.Write("Bölecek sayıyı giriniz:");
            string bolen = Console.ReadLine();
            double s2 = Convert.ToDouble(bolen);
            double kalan = (double)(s1 % s2);
            Console.WriteLine("Bölüm: "+(s1/s2));
            Console.WriteLine("Bu bölme işleminin kalanı: " + kalan);
            Console.WriteLine("Klavyeden herhangi bir tuşa basıp programı kapatabilirsiniz.");
            Console.ReadKey();


           
            
        }
    }
}
