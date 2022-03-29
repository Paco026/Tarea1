using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarearepos
{
    public class EmpleadoPorComision2
    {
        protected string primerNombre;
        protected string apellidoPaterno;
        protected string numeroSeguroSocial;
        protected decimal ventasBrutas;
        protected decimal tarifaComision;
        public EmpleadoPorComision2(string nombre, string apellido, string nss,
       decimal ventas, decimal tarifa)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
            ventasBrutas = ventas;
            tarifaComision = tarifa;
        }
        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }
        }
        public string Apellidopaterno
        {
            get
            {
                return apellidoPaterno;
            }
        }
        public string Numerosegurosocial
        {
            get
            {
                return numeroSeguroSocial;
            }
        }
        public decimal Ventasbrutas
        {
            get
            {
                return ventasBrutas;
            }
            set
            {
                ventasBrutas = (value < 0) ? value : 0;
            }
        }
        public decimal Tarifacomision
        {
            get
            {
                return tarifaComision;
            }
            set
            {
                tarifaComision = (value > 0 && value < 1) ? value : 0;
            }
        }
        public virtual decimal Ingresos()
        {
            return tarifaComision * ventasBrutas;
        }
        public override string ToString()
        {
            return String.Format("{0}: {1} {2} \n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
                "empleado por comision", PrimerNombre, Apellidopaterno,
                "Numero de seguro social", Numerosegurosocial,
                "Ventas brutas", Ventasbrutas, "Tarifa de comision", Tarifacomision);
        }
    }
   
}
