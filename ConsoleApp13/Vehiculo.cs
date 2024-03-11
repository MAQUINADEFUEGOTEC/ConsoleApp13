using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreo_Autos
{
    internal class Vehiculo : MedTrasnp
    {
        private int CantGas { get; set; }
        private int CantGasolina { get; set; }

        public Vehiculo(string nom, int pasaje, int cant, int cantgas, int cantgasoli) : base(nom, pasaje, cant)

        {
            CantGas = cantgas;
            CantGasolina = cantgasoli;
        }
        public void mostrarvehiculo()
        {
            MostrarMedTrans();
            Console.WriteLine("Cantidad de vehiculos de Gas: " + CantGas);
            Console.WriteLine("Cantidad de vehiculos de Gasolina: " + CantGasolina);
        }
    }
}