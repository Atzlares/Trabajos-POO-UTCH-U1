using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            planetas pl1 = new planetas();
            pl1.masa = 10000000;
            pl1.tamano = 142344;
            pl1.agua = true;
            pl1.tierra = false;
            pl1.gravedad = 1.67f; //Se le agrega f para valor flotante en la terminacion de un valor numerico
            pl1.orbita = 142344142344;
            pl1.GenerarEcosistema();

            planetas pl2 = new planetas();
            pl2.masa = 25000000;
            pl2.tamano = 5142344;
            pl2.agua = false;
            pl2.tierra = false;
            pl2.gravedad = 2.67f; //Se le agrega f para valor flotante en la terminacion de un valor numerico
            pl2.orbita = 142344142344;
            pl2.GenerarEcosistema();
        }
    }
}
