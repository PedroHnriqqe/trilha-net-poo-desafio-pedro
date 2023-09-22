using DesafioPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Iphone iphone = new Iphone("1199999999", "Iphone xs", "3242314132", 120);

            iphone.InstalarAplicativo("Whatsapp");
            iphone.Ligar();

            Nokia nokia = new Nokia("1144322222", "Nokita Tijolao i5", "2343125123", 65);
            nokia.InstalarAplicativo("Telegram");
            nokia.Ligar();
        }
    }
}
