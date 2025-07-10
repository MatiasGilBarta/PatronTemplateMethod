using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class ConstruccionCasa
    {
        public void ConstruirCasa()
        {
            RealizarPlanos();
            ConstruirCimientos();
            ConstruirPrimerPiso();


            if (ConstruirSegundoPisoRequerido())
            {
                ConstruirSegundoPiso();
            }
            ConstruirTecho();

            if (ConstruirSotanoRequerido())
            {
                ConstruirSotano();
            }
            ColocarAcabados();

            if (PintarRequerido())
            {
                Pintar();
            }
        }

        protected abstract void RealizarPlanos();

        protected abstract void ConstruirCimientos();

        protected abstract void ConstruirPrimerPiso();

        protected abstract void ConstruirTecho();

        protected abstract void ColocarAcabados();

        protected virtual bool PintarRequerido()
        {
            return true;
        }

        protected virtual void Pintar()
        {
            Console.WriteLine("Pintando la casa\n");
        }

        protected virtual bool ConstruirSegundoPisoRequerido()
        {
            return true;
        }

        protected virtual void ConstruirSegundoPiso()
        {
            Console.WriteLine("Construyendo el segundo piso\n");
        }

        protected virtual bool ConstruirSotanoRequerido()
        {
            return true;
        }

        protected virtual void ConstruirSotano()
        {
            Console.WriteLine("Construyendo el sotano\n");
        }
    }
}
