using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    class Automovil
    {
        public string Color;
        public string Marca;
        public int Modelo;
        enum AIREACONDICIONADO { APAGADO, FRIO, CALIENTE}
        enum INTENSIDADDELUCES { BAJAS, NORMALES, ALTAS }
    
        public Automovil()
        {
            Marca = "BMW";
            Modelo = 2018;
            Color = "Negro";
        }

        public Automovil(string marca, int modelo, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
        }

        public bool Luces(int intensidad)
        {
            bool resultado = false;
            if (intensidad == (int)INTENSIDADDELUCES.ALTAS)
            {
                resultado = false;
            }
            else if (intensidad == (int)INTENSIDADDELUCES.BAJAS)
            {
                resultado = true;
            }
            else if (intensidad == (int)INTENSIDADDELUCES.NORMALES)
            {
                resultado = true;
            }

            return resultado;
        }
        public bool Aire (int funcionamiento)
        {
            bool respuesta = false;
            if (funcionamiento == (int)AIREACONDICIONADO.APAGADO)
            {
                respuesta = false;
            }
            else if (funcionamiento == (int)AIREACONDICIONADO.FRIO)
            {
                respuesta = true;
            }
            else if (funcionamiento == (int)AIREACONDICIONADO.CALIENTE)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
