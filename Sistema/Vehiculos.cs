using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    public class Vehiculos
    {
        //Atributos
        private string marca;
        private string modelo;
        private int anio;
        private string matricula;
        private DateTime ultimoServicio;

        //Constructor
        public Vehiculos(string marca, string modelo, int anio, string matricula, DateTime ultimoServicio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.matricula = matricula;
            this.ultimoServicio = ultimoServicio;
        }

        //Propertys
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public DateTime UltimoServicio
        {
            get { return ultimoServicio; }
            set { ultimoServicio = value; }
        }


        //Validaciones
        public bool Validar()
        {
            return ValidarMarca() && ValidarModelo() && SoloLetras(this.marca) && SoloLetras(this.modelo) && ValidarAnio() && ValidarMatricula(this.matricula);
        }


        public bool ValidarMarca()
        {
            return !string.IsNullOrEmpty(this.marca);
        }


        public bool ValidarModelo()
        {
            return !string.IsNullOrEmpty(this.modelo);
        }


        public bool SoloLetras(string palabra)
        {
            bool exito = true;
            string palabraMinusculas = palabra.ToLower();
            int i = 0;
            char letra = palabraMinusculas[i];

            do
            {
                if(letra <= 'a' && letra >= 'z')
                {
                    exito = false;
                }
                i++;
            } while (!exito && i < palabraMinusculas.Length);

            return exito;
        }


        public bool SoloNumeros(string palabra)
        {
            bool exito = true;
            
            int i = 0;
            char letra = palabra[i];

            do
            {
                if (letra <= '0' && letra >= '9')
                {
                    exito = false;
                }
                i++;
            } while (!exito && i < palabra.Length);

            return exito;
        }



        public bool ValidarAnio()
        {
            return this.anio >= 1990 && this.anio <= DateTime.Now.Year;
        }



        public bool ValidarMatricula(string matricula)
        {
            bool exito = false;
            string tresPimeros = matricula.Substring(0, 3);
            string tresUltimos = matricula.Substring(0, 3);

            if(SoloLetras(tresPimeros) && SoloNumeros(tresUltimos))
            {
                exito = true;
            }

            return exito;
        }


    }
}
