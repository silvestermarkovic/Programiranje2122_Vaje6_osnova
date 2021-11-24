using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Zaposleni
{
       class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //TODO 30
            //ustvarite seznam zaposlenih
            List<Zaposleni> seznam = new List<Zaposleni>();




            //TODO 31
            //kličite metodo, ki ste jo ustvarili in napolnite seznam z zaposlenimi
            NapolniSeznam(seznam);





            //TODO 32
            //izracunajte povprecno placo in jo shranite v spremenljivko: povprecnaplaca
            double povprecnaplaca = seznam.Average(s => s.employee_salary);

            //po vsaki poizvedbi izpisite seznam (uporabite razsiritev TODO25) !!!!
            //TODO 33
            //ustvarite seznam ljudi, ki majo placo visjo od povprecneplace z uporabo Linq
            var poiz1 = from zap1 in seznam
                        where zap1.employee_salary > povprecnaplaca
                        select new { zap1.employee_name, zap1.employee_salary, zap1.employee_age };
            poiz1.ReadEnumerable();

            
                        

            //TODO 35
            //izpisite zaposlene, ki so stari med 30 in 50 let, razvrstite jih po placi padajoce
            var poiz2 = from zap2 in seznam
                        where zap2.employee_age >= 30 && zap2.employee_age <= 50
                        select new { zap2.employee_name, zap2.employee_salary, zap2.employee_age };
            poiz2.ReadEnumerable();

            //TODO 36
            //grupirajte zaposlene glede na starost (3x) je grupa 3, (4x)je grupa 4 in inzračunajte seštevek njihovih, plač in koliko je zaposlenih v tej grupi
            var poiz3 = from zap2 in seznam
                        group zap2 by (int)zap2.employee_age / 10 into gr
                        select new
                        {
                            gr.Key,
                            Stevilo = gr.Count(),
                            SestevkPlac = gr.Sum(s => s.employee_salary)
                        };
            poiz3.ReadEnumerable();

        }


        public static void NapolniSeznam(List<Zaposleni> seznam)
        {

            //TODO 3.1
            //dodajte Nuget Newtonsoft.Json in odkomentirajte 
            string vsebina = "";
            using (var webClient = new System.Net.WebClient())
            {
                vsebina = webClient.DownloadString("http://dummy.restapiexample.com/api/v1/employees");
            }
            JToken token = JToken.Parse(vsebina);
            JArray zaposleni = (JArray)token.SelectToken("data");
            foreach (JToken zap in zaposleni)
            {
                seznam.Add(new Zaposleni() { id = (int)zap["id"], employee_name = (string)zap["employee_name"], employee_age = (int)zap["employee_age"], employee_salary = (double)zap["employee_salary"] });
            }
        }
    }
}
