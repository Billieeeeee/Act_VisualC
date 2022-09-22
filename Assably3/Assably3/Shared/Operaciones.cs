using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assably3.Shared
{
    public class Operacion
    {

        private int numeroA;
        private int numeroB;
        private string operacionAritmetica;
        private float resultado;

        public Operacion(int numeroA, int numeroB, float resultado)
        {
            this.numeroA = numeroA;
            this.numeroB = numeroB;
            this.resultado = resultado;
        }

        public int NumeroA { get => numeroA; set => numeroA = value; }
        public int NumeroB { get => numeroB; set => numeroB = value; }
        public string OperacionAritmetica { get => operacionAritmetica; set => operacionAritmetica = value; }
        public float Resultado { get => resultado; set => resultado = value; }
    }
}
