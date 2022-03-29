using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarearepos
{
    public class EmpleadoBaseMasComision3 : EmpleadoPorComision2
    {
        private decimal salarioBase;
        public EmpleadoBaseMasComision3(string nombre, string apellido, string nss,
        decimal ventas, decimal tarifa,decimal salario)
        : base(nombre, apellido, nss, ventas, tarifa)
        {
            salarioBase = salario;
        }
        public decimal Salariobase
        {
            get
            {
                return salarioBase;
            }
            set
            {
                salarioBase = (value < 0) ? 0 : value;
            }
        }
        public override decimal Ingresos()
        {
            return salarioBase + (tarifaComision * ventasBrutas);
        }
        public override string ToString()
        {
            return String.Format("{0}: {1} {2} \n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
                "empleado por comision", primerNombre, apellidoPaterno,
                "Numero de seguro social", numeroSeguroSocial,
                "Ventas brutas", Ventasbrutas, "Tarifa de comision", Tarifacomision,
                "Salario Base ",salarioBase);
        }
    }

}
