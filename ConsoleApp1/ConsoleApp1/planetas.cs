using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class planetas
    {
        public double masa;
        public int tamano;
        //public string propiedades;
        public bool agua;
        public bool tierra;
        public float orbita;
        public float gravedad;

        public void GenerarEcosistema()
        {
            if (agua && tierra && gravedad < 2)
            {
                Console.WriteLine("Se generó un ecosistema");
            }

        }
    }
}
