using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreo_Autos
{
    internal class Moto : MedTrasnp
    {
        private int cantCilindraje250 { get; set; }

        public Moto(string nom, int pasaje, int cant, int cc250) : base(nom, pasaje, cant)

        {
            cantCilindraje250 = cc250;
        }

        public void mostrarmoto()
        {

            MostrarMedTrans();
            Console.WriteLine("Cantidad de motos con cilindraje mayor a 250: " + cantCilindraje250);

        }

    }
}