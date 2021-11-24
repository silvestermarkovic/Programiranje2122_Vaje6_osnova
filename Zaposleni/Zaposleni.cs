using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaposleni
{
    //TODO 10
    //ustvarite razred zaposleni
    //      id      int
    //      employee_name string
    //      employee_salary double
    //      employee_age int
    public class Zaposleni
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public double employee_salary { get; set; }
        public int employee_age { get; set; }


    }
     

    //TODO 20
    //ustvarite metodo (ali več metod, ki bo napolnila seznam zaposlenih (ki ga dobi kot parameter) 
    //http://dummy.restapiexample.com/api/v1/employees (namig vaje 2)
   

    //TODO 25
    //ustvarite razširitev, ki izpiše seznam elementov (namig: smo že uporabljali)

    public static class Extensions
    {
            public static void ReadEnumerable<T>(this IEnumerable<T> list)
        {
            Console.Write("Elementi seznama so: ");
            int count = 0;
            foreach (var item in list)
            {
                count++;
                Console.WriteLine( item.ToString() + $"{(count == list.Count() ? Environment.NewLine : ",")} ");


            }
            Console.WriteLine();
        }
 
    }
}
