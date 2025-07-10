using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CasaMadera : ConstruccionCasa
    {
        private readonly bool pintarRequerido;
        private readonly bool construirSegundoPisoRequerido;
        private readonly bool construirSotanoRequerido;

        public CasaMadera(bool pintarRequerido, bool construirSegundoPisoRequerido, bool construirSotanoRequerido)
        {
            this.pintarRequerido = pintarRequerido;
            this.construirSegundoPisoRequerido = construirSegundoPisoRequerido;
            this.construirSotanoRequerido = construirSotanoRequerido;
        }

        //eso de arriba lo hacemos para que haya algun dato, para usarlo para decirnos si hay que usarlo o no, ya que son opcionales

        protected override void ColocarAcabados()
        {
            Console.WriteLine("Colocando los acabados de una casa de madera\n");
        }

        protected override void ConstruirCimientos()
        {
            Console.WriteLine("Construyendo los cimientos de una casa de madera\n");
        }

        protected override void ConstruirPrimerPiso()
        {
            Console.WriteLine("Construyendo el primer piso de una casa de madera\n");
        }

        protected override void ConstruirTecho()
        {
            Console.WriteLine("Construyendo el techo de una casa de madera\n");
        }

        protected override void RealizarPlanos()
        {
            Console.WriteLine("Realizando los planos de una casa de madera\n");
        }

        protected override bool PintarRequerido()
        {
            return pintarRequerido;
        }

        protected override bool ConstruirSegundoPisoRequerido()
        {
            return construirSegundoPisoRequerido;
        }

        protected override bool ConstruirSotanoRequerido()
        {
            return construirSotanoRequerido;
        }
    }
}
