using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    public class Comunes : Vehiculos
    {
        //Atributos
        private string tipoNafta;
        private int cantidadOcupantes;

        //Propertys
        public string TipoNafta
        {
            get { return tipoNafta; }
            set { tipoNafta = value; }
        }
    
        public int CantidadOcupantes
        {
            get { return cantidadOcupantes; }
            set { cantidadOcupantes = value; }
        }


        //Constructor
        public Comunes(string tipoNafta, int cantidadOcupantes, string marca, string modelo, int anio, string matricula, DateTime ultimoServicio) : base(marca, modelo, anio, matricula, ultimoServicio)
        {
            this.TipoNafta = tipoNafta;
            this.CantidadOcupantes = cantidadOcupantes;
        }

        public override bool Equals(object obj)
        {
            Comunes comun = obj as Comunes;
            return obj != null && Matricula == comun.Matricula;
        }

        public override string ToString()
        {
            return $"MARCA: {base.Marca} MATRICULA: {base.Matricula} ULTIMO SERVICIO: {UltimoServicio} COMUN"; 
        }
    }
}
