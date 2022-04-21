using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    public class Administradora
    {
        List<Comunes> comunes = new List<Comunes>();
        List<Carga> carga = new List<Carga>();

        public Administradora()
        {
            precargaVehiculosComunes();
            precargaVehiculosCarga();
        }

        private void precargaVehiculosComunes()
        {
            Comunes unComun;
            
            unComun = new Comunes("Diesel", 4, "Mercedes", "Fargo", 2018, "ert456", new DateTime(2019, 12, 21));
            AgregarVehiculoComun(unComun);

            unComun = new Comunes("Gas Oil", 2, "Fusca", "Matrez", 2020, "fgh257", new DateTime(2020, 11, 15));
            AgregarVehiculoComun(unComun);

            unComun = new Comunes("Gas Oil", 3, "Ferrari", "Pilo", 2021, "sew345", new DateTime(2021, 11, 23));
            AgregarVehiculoComun(unComun);

            unComun = new Comunes("Diesel", 6, "Primordial", "Fargo", 2012, "yui789", new DateTime(2021, 10, 12));
            AgregarVehiculoComun(unComun);
        }

        public void precargaVehiculosCarga()
        {
            Carga unCarga;
            
            unCarga = new Carga(200, 4, "Fiat", "ElCatorce", 2020, "wdc345", new DateTime(2020, 11, 29));
            AgregarVehiculoCarga(unCarga);

            unCarga = new Carga(300, 5, "Mercurio", "ebe", 2021, "ert337", new DateTime(2021, 11, 29));
            AgregarVehiculoCarga(unCarga);

            unCarga = new Carga(100, 3, "McLaren", "Modleo2", 2022, "wdc234", new DateTime(2021, 11, 29));
            AgregarVehiculoCarga(unCarga);

            unCarga = new Carga(500, 2, "Fiorell", "lala", 2022, "wdc789", new DateTime(2021, 11, 29));
            AgregarVehiculoCarga(unCarga);

        }


        public bool AgregarVehiculoComun(Comunes unComun)
        {
            bool exito = false;

            if(unComun != null && unComun.Validar() && !comunes.Contains(unComun))
            {
                comunes.Add(unComun);
                exito = true;
            }
            return exito;
        }


        public bool AgregarVehiculoCarga(Carga unCarga)
        {
            bool exito = false;

            if (unCarga != null && unCarga.Validar() && !carga.Contains(unCarga))
            {
                carga.Add(unCarga);
                exito = true;
            }
            return exito;
        }


        public List<Comunes> VehiculosComunes()
        {
            List<Comunes> aux = new List<Comunes>();

            foreach (Comunes item in comunes)
            {
                aux.Add(item);
            }
            return aux;
        }

        public List<Carga> VehiculosCarga()
        {
            List<Carga> aux = new List<Carga>();

            foreach (Carga item in carga)
            {
                aux.Add(item);
            }
            return aux;
        }

    }
}
