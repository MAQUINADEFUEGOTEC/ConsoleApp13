using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreo_Autos
{
    internal class MedTrasnp
    {
        protected string Nombre { get; set; }
        protected int CapPasaje { get; set; }
        protected int Cantidad { get; set; }

        public MedTrasnp(string nom, int pasaje, int cant)
        {
            this.Nombre = nom;
            this.CapPasaje = pasaje;
            this.Cantidad = cant;
        }
        public int CalcularPer()
        {

            return (CapPasaje * Cantidad);
        }

        public void MostrarMedTrans()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Cantidad de pasajeros: " + CapPasaje);
            Console.WriteLine("Cantidad que ingresan al dia: " + Cantidad);

        }
    }
}