using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    public class Administradora
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public Administradora()
        {
            precargaVehiculosComunes();
            precargaVehiculosCarga();
        }

        private void precargaVehiculosComunes()
        {
            Comun unComun;
            
            unComun = new Comun("nafta", 4, "Mercedes", "Fargo", 2018, "ert456", new DateTime(2019, 12, 21));
            AgregarVehiculoComun(unComun);

            unComun = new Comun("gasoil", 2, "Fusca", "Matrez", 2015, "fgh257", new DateTime(2020, 11, 15));
            AgregarVehiculoComun(unComun);

            unComun = new Comun("electrico", 4, "Ferrari", "Pilo", 2005, "sew345", new DateTime(2021, 11, 23));
            AgregarVehiculoComun(unComun);

            unComun = new Comun("nafta", 6, "Primordial", "Fargo", 2012, "yui789", new DateTime(2021, 10, 12));
            AgregarVehiculoComun(unComun);
        }

        public void precargaVehiculosCarga()
        {
            Carga unCarga;
            
            unCarga = new Carga(200, 4, "Fiat", "ElCatorce", 2001, "wdc345", new DateTime(2020, 11, 29));
            AgregarVehiculoCarga(unCarga);

            unCarga = new Carga(300, 5, "Mercurio", "Ebe", 2016, "ert337", new DateTime(2021, 11, 29));
            AgregarVehiculoCarga(unCarga);

            unCarga = new Carga(100, 3, "McLaren", "Modleo", 2017, "wdc234", new DateTime(2021, 11, 29));
            AgregarVehiculoCarga(unCarga);

            unCarga = new Carga(500, 2, "Fiorell", "lala", 2015, "wdc789", new DateTime(2021, 11, 29));
            AgregarVehiculoCarga(unCarga);

        }

        public bool AgregarVehiculoComun(Comun unComun)
        {
            bool exito = false;

            if(unComun != null && unComun.Validar() && !vehiculos.Contains(unComun))
            {
                vehiculos.Add(unComun);
                exito = true;
            }
            return exito;
        }

        public bool AgregarVehiculoCarga(Carga unCarga)
        {
            bool exito = false;
            if (unCarga != null && unCarga.Validar() && !vehiculos.Contains(unCarga))
            {
                vehiculos.Add(unCarga);
                exito = true;
            }
            return exito;
        }

        public List<Comun> VehiculosComunes()
        {
            List<Comun> aux = new List<Comun>();
            foreach (Vehiculo item in vehiculos)
            {
                if(item is Comun)
                {
                    aux.Add((Comun)item);
                }
            }
            return aux;
        }

        public List<Carga> VehiculosCarga()
        {
            List<Carga> aux = new List<Carga>();
            foreach (Vehiculo item in vehiculos)
            {
                if(item is Carga)
                {
                    aux.Add((Carga)item);
                }
                
            }
            return aux;
        }


        public List<Vehiculo> TodosLosVehiculosOrdenadosPorMarca()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            foreach (Vehiculo item in vehiculos)
            { 
                aux.Add(item);
            }

            aux.Sort(new OrdenarVehiculosPorMarca());
            return aux;
        }

        public List<Vehiculo> TodosLosVehiculosOrdenadosPorAnio()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            foreach (Vehiculo item in vehiculos)
            {
                aux.Add(item);
            }

            aux.Sort(new OrdenarVehiculosPorAnio());
            return aux;
        }

        public List<Vehiculo> ServicioPendienteEsteAnio()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            foreach (Vehiculo item in vehiculos)
            {
                if(item.CalcularProximoServicio.CompareTo(DateTime.Now) == 1)
                {
                    aux.Add(item);
                }
            }
            return aux;
        }


    }
}
