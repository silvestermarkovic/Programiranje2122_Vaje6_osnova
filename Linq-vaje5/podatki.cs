using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_vaje5
{
    public class Kupec
    {
        public int ID_kupca { get; set; }
        public string naziv { get; set; }
        public string kraj { get; set; }
        public string drzava { get; set; }

        public Kupec(int pID_kupca, string pnaziv, string pkraj, string pdrzava)
        {
            ID_kupca = pID_kupca;
            naziv = pnaziv;
            kraj = pkraj;
            drzava = pdrzava;
        }

        public override string ToString()
        {
            return $"{this.ID_kupca} {this.naziv} {this.kraj} {this.drzava} ";
        }
    }

    public class Dokument
    {
        public string ID_dokumenta { get; set; }
        public int ID_kupca { get; set; }
        public double znesek { get; set; }

        public Dokument(string p_ID_dokumenta, int pID_kupca, double pznesek)
        {
            ID_dokumenta = p_ID_dokumenta;
            ID_kupca = pID_kupca;
            znesek = pznesek;
        }

        public override string ToString()
        {
            return $"Dok: {this.ID_dokumenta} Kupec: {this.ID_kupca} Znesek: {this.znesek}  ";
        }
    }


    public static class Extensions
    {
        public static void ReadEnumerable<T>(this IEnumerable<T> list)
        {
            Console.Write("Elementi seznama so: ");
            int count = 0;
            foreach (var item in list)
            {
                count++;
                Console.WriteLine(item.ToString() + $"{(count == list.Count() ? Environment.NewLine : ",")} ");
            }
            Console.WriteLine();
        }
    }
}
