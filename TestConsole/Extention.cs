using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public static class Extention
    {
        /// <summary>
        ///  Helper
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string NormalizeEdNormalMethod(string input)
        {
            return input.Trim().Replace(" ", "").ToUpper().Replace("i", "I").Replace("ğ", "G");
        }
    }


    public class Berkay
    {
        public int ID { get; set; }
        public string NAme  { get; set; }

        public void Selamver()
        {
            Console.WriteLine("Selam Verildi. ");
        }
    }
}
