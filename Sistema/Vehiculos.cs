using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Sistema
{
    public abstract class Vehiculo : IEquatable<Vehiculo>, IValidable
    {
        //Atributos
        private string marca;
        private string modelo;
        private int anio;
        private string matricula;
        private DateTime ultimoServicio;

        //Constructor
        public Vehiculo(string marca, string modelo, int anio, string matricula, DateTime ultimoServicio)
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

        public DateTime CalcularProximoServicio
        {
            get { return ProximoServicio();}
        }



        //Validaciones
        public virtual bool Validar()
        {
            return
                ValidarMarca() &&
                ValidarModelo() &&
                ValidarAnio() &&
                ValidarMatricula() &&
                Validaciones.SoloLetras(this.marca) &&
                Validaciones.SoloLetras(this.modelo);
        }

        private bool ValidarMarca()
        {
            return !string.IsNullOrEmpty(this.marca);
        }


        private bool ValidarModelo()
        {
            return !string.IsNullOrEmpty(this.modelo);
        }

        private bool ValidarAnio()
        {
            return this.anio >= 1990 && this.anio <= DateTime.Now.Year;
        }

        private bool ValidarMatricula()
        {
            bool exito = false;
            string tresPimeros = this.matricula.Substring(0, 3);
            string tresUltimos = this.matricula.Substring(3, 3);
            if (Validaciones.SoloLetras(tresPimeros) && Validaciones.SoloNumeros(tresUltimos))
            {
                exito = true;
            }
            return exito;
        }


        public bool Equals(Vehiculo unVehiculo)
        {
            return unVehiculo != null && Matricula == unVehiculo.Matricula;
        }

        public DateTime ProximoServicio()
        {
            return this.ultimoServicio.AddYears(1);
        }
    }

    public class OrdenarVehiculosPorMarca : IComparer<Vehiculo>
    {
        public int Compare(Vehiculo x, Vehiculo y)
        {
            return x.Marca.CompareTo(y.Marca);
        }
    }

    public class OrdenarVehiculosPorAnio : IComparer<Vehiculo>
    {
        public int Compare(Vehiculo x, Vehiculo y)
        {
            return x.Anio.CompareTo(y.Anio);
        }
    }
}
