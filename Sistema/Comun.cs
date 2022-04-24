using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    public class Comun : Vehiculo, IValidable
    {
        //Atributos
        private string tipoCombustible;
        private int cantidadOcupantes;

        //Propertys
        public string TipoCombustible
        {
            get { return tipoCombustible; }
            set { tipoCombustible = value; }
        }
    
        public int CantidadOcupantes
        {
            get { return cantidadOcupantes; }
            set { cantidadOcupantes = value; }
        }

        //Constructor
        public Comun(string tipoCombustible, int cantidadOcupantes, string marca, string modelo, int anio, string matricula, DateTime ultimoServicio) : base(marca, modelo, anio, matricula, ultimoServicio)
        {
            this.TipoCombustible = tipoCombustible;
            this.CantidadOcupantes = cantidadOcupantes;
        }

        //Validaciones
        public override bool Validar()
        {
            return
                base.Validar() &&
                Validaciones.ValidarTipoCombustible(this.tipoCombustible) &&
                Validaciones.ValidarOcupantes(this.cantidadOcupantes);
        }


        public override string ToString()
        {
            return $"MARCA: {base.Marca}\nMATRICULA: {base.Matricula}\nANIO: {base.Anio}\nULTIMO SERVICIO: {UltimoServicio.ToString("d")}\nPROXIMO SERVICIO: {base.ProximoServicio().ToString("d")}\nTIPO:COMUN\n-------------------"; 
        }
    }
}
