using System.Security.Cryptography.X509Certificates;

namespace TiendaBiblioteca
{
    public class Tienda
    {
        public int Antigüedad { get; set; }  
        public Departamento[] departamentos { get; set; }

        public Tienda() 
        {
            Console.Write("Ingrese la Antigüedad de la tienda: ");
            Antigüedad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cuántos departamentos va a tener de la tienda: ");
            int CantDepartamentos = Convert.ToInt32(Console.ReadLine());

            departamentos = new Departamento[CantDepartamentos];

            for (int i = 0; i < departamentos.Length; i++)
            {
                departamentos[i] = new Departamento();
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Piso     Tipo de Producto");
            Console.WriteLine("-------------------------");
            for(int i = 0;i < departamentos.Length;i++)
            {
                Console.WriteLine(departamentos[i].Piso + "        " + departamentos[i].TipoProducto);

            }
        }
    }
}