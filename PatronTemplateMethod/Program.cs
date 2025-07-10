using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace PatronTemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pintarRequerido1 = true;
            bool construirSegundoPisoRequerido1 = false;
            bool construirSotano1 = true;

            ConstruccionCasa construccionCasa1 = new CasaLadrillo(pintarRequerido1, construirSegundoPisoRequerido1, construirSotano1);
            construccionCasa1.ConstruirCasa();

            bool pintarRequerido2 = true;
            bool construirSegundoPisoRequerido2 = false;
            bool construirSotano2 = true;

            ConstruccionCasa construccionCasa2 = new CasaMadera(pintarRequerido2, construirSegundoPisoRequerido2, construirSotano2);
            construccionCasa2.ConstruirCasa();
            Console.ReadLine();
        }
    }
}
