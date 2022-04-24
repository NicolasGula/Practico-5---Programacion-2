using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    public static class Validaciones
    {
        public static bool SoloLetras(string palabra)
        {
           bool exito = true;
           foreach(char letra in palabra)
            {
                if (!Char.IsLetter(letra))
                {
                    exito =  false;
                }
            }
            return exito; 
        }

        public static bool SoloNumeros(string palabra)
        {
            bool exito = true;
            foreach (char letra in palabra)
            {
                if (!Char.IsDigit(letra))
                {
                    exito = false;
                }
            }
            return exito;
        }

        public static bool ValidarNumeroMayorACero(int valor)
        {
            return valor > 0;
        }

        public static bool ValidarTipoCombustible(string combustible)
        {
            return combustible.ToLower() == "nafta" || combustible.ToLower() == "gasoil" || combustible.ToLower() == "electrico";
        }

        public static bool ValidarOcupantes(int ocupantes)
        {
            return ValidarNumeroMayorACero(ocupantes) && ocupantes == 2 || ocupantes == 4 || ocupantes == 6 || ocupantes == 8;
        }

        //Mejoras
        //char.isLetter
        //char.isDigit




    }
}
