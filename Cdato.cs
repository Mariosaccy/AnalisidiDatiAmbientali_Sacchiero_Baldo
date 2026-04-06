using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisidiDatiAmbientali_Sacchiero_Baldo
{
    public class Cdato
    {

        public string Citta { get; set; }
        public DateTime DataOra { get; set; }
        public double Temperatura { get; set; }
        public double Pm25 { get; set; }
        public double Pm10 { get; set; }
        public int IndiceEpa { get; set; }

        public Cdato(string citta, DateTime dataOra, double temperatura, double pm25, double pm10, int indiceEpa)
        {
            Citta = citta;
            DataOra = dataOra;
            Temperatura = temperatura;
            Pm25 = pm25;
            IndiceEpa = indiceEpa;
            Pm10 = pm10;
        }

    }
}
