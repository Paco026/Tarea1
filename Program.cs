using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarearepos
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpleadoBaseMasComision3 empleadoBaseMasComision = new EmpleadoBaseMasComision3("Bob", "Lewis", "333-33-333", 5000.00M, .04M, 300.00M);


            Console.WriteLine("Informacion del empleado obtenida por las propiedades y los metodos: \n");
            Console.WriteLine("{0} {1}","El primer nombre es: ",empleadoBaseMasComision.PrimerNombre);
            Console.WriteLine("{0} {1}","El apellido paterno es: ",empleadoBaseMasComision.Apellidopaterno);
            Console.WriteLine("{0} {1}","El nummero de seguro social es: ",empleadoBaseMasComision.Numerosegurosocial);
            Console.WriteLine("{0} {1:C}","Las ventas brutas son: ",empleadoBaseMasComision.Ventasbrutas);
            Console.WriteLine("{0} {1:F2}","La tarifa de comicion es:",empleadoBaseMasComision.Tarifacomision);
            Console.WriteLine("{0}{1:C}","Los ingresos son: ",empleadoBaseMasComision.Ingresos());
            Console.WriteLine("{0}{1:C}","El salario base es: ",empleadoBaseMasComision.Salariobase);
            empleadoBaseMasComision.Salariobase = 1000.00M;
            Console.WriteLine("\n{0}:\n\n{1}",
                "Informacion actualizada del empleado,  obtenida por ToString",
                empleadoBaseMasComision);
            Console.WriteLine("Ingresos {0:C}",empleadoBaseMasComision.Ingresos());
            Console.ReadKey();
        } 
    }
}
