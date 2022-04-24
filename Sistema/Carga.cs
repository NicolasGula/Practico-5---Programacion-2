using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    public class Carga : Vehiculo, IValidable
    {
        //Atributos
        private int capacidadCarga;
        private int cantidadEjes;

        //Propertys
        public int CapacidadCarga
        {
            get { return capacidadCarga; }
            set { capacidadCarga = value; }
        }

        public int CantidadEjes
        {
            get { return cantidadEjes; }
            set { cantidadEjes = value; }
        }

        //Constructor
        public Carga(int capacidadCarga, int cantidadEjes, string marca, string modelo, int anio, string matricula, DateTime ultimoServicio) : base(marca, modelo, anio, matricula, ultimoServicio)
        {
            this.CapacidadCarga = capacidadCarga;
            this.CantidadEjes = cantidadEjes;
        }

        public override bool Validar()
        {
            return
                base.Validar() && //Validaciones que hereda de Vehiculos.
                Validaciones.ValidarNumeroMayorACero(cantidadEjes) &&
                Validaciones.ValidarNumeroMayorACero(capacidadCarga);
        }

        //ToString
        public override string ToString()
        {
            return $"MARCA: {base.Marca}\nMATRICULA: {base.Matricula}\nANIO: {base.Anio}\nULTIMO SERVICIO: {UltimoServicio.ToString("d")}\nPROXIMO SERVICIO: {base.ProximoServicio().ToString("d")}\nTIPO : DE CARGA\n-------------------";
        }
    }
}
