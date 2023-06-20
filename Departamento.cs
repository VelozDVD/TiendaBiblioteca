using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaBiblioteca
{
    public class Departamento
    {
        public string TipoProducto { get; set; }
        public int Piso;
        public Departamento() 
        {
            Console.Write("Ingrese el tipo de producto: ");
            TipoProducto = Console.ReadLine();
            Console.Write("Ingrese el piso donde se encuentra el departamento: ");
            Piso = Convert.ToInt32(Console.ReadLine());

        }
    }
}
