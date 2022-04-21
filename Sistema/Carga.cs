using System;

namespace Sistema
{
    public class Carga : Vehiculos
    {
        //Atributos
        private decimal capacidadCarga;
        private int cantidadEjes;


        //Propertys
        public decimal CapacidadCarga
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
        public Carga(decimal capacidadCarga, int cantidadEjes, string marca, string modelo, int anio, string matricula, DateTime ultimoServicio) : base(marca, modelo, anio, matricula, ultimoServicio)
        {
            this.CapacidadCarga = capacidadCarga;
            this.CantidadEjes = cantidadEjes;
        }


        public override string ToString()
        {
            return $"MARCA: {base.Marca} MATRICULA: {base.Matricula} ULTIMO SERVICIO: {UltimoServicio} DE CARGA ";
        }


        public override bool Equals(object obj)
        {
            Carga carga = obj as Carga;
            return obj != null && Matricula == carga.Matricula;
        }
    }
}
