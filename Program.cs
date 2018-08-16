using System;

namespace Transporte
{
    class Program
    {
        enum AIREACONDICIONADO { APAGADO, FRIO, CALIENTE }
        enum INTENSIDADDELUCES {BAJAS, NORMALES, ALTAS}
        static void Main(string[] args)
        {
            bool intensidades = false;

            Automovil Automovil1 = new Automovil();

            Automovil1.Marca = "MERCEDES BENZ";
            Automovil1.Modelo = 2017;
            Automovil1.Color = "Blanco";

            intensidades = Automovil1.Luces((int)INTENSIDADDELUCES.BAJAS);

            if (intensidades)
            {
                Console.WriteLine("El automovil " + Automovil1.Marca + " tiene las luces " + Convert.ToString(INTENSIDADDELUCES.ALTAS) + " encendidas");
            }
            else
            {
                Console.WriteLine("Aun no apagan las luces");
            }

            Automovil Automovil2 = new Automovil();
            Console.WriteLine("El automovil " + Automovil2.Marca + " tiene las luces " + Convert.ToString(INTENSIDADDELUCES.BAJAS) + " encendidas");
            

            bool temperatura = false;
            temperatura = Automovil1.Aire((int)AIREACONDICIONADO.APAGADO);
            
            if (temperatura)
            {
                Console.WriteLine("El automovil " + Automovil1.Marca + " tiene el aire acondionado  " + Convert.ToString(AIREACONDICIONADO.FRIO) + " encendido");
            }
            else
            {
                Console.WriteLine("Checar el funcionamiento del aire del automovil " + Automovil1.Marca);
            }
            Automovil Automovil3 = new Automovil();
            Console.WriteLine("El automovil " + Automovil3.Marca + " tiene el aire acondiconado " + Convert.ToString(AIREACONDICIONADO.CALIENTE) + " encendido");
            Console.Read();
        }   

    }
}
