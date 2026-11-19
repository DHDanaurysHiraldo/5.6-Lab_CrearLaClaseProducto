using System;
using System.Collections.Generic;
using System.Text;

namespace _5_6_Lab_CrearLaClaseProducto
{
    public class Producto
    {
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("----- Producto -----");
            Console.WriteLine($"Código   : {Codigo}");
            Console.WriteLine($"Nombre   : {Nombre}");
            Console.WriteLine($"Precio   : RD${Precio:N2}");
            Console.WriteLine($"Cantidad : {Cantidad}");
        }

        public decimal CalcularValorTotal()
        {
            return Precio * Cantidad;
        }

    }
}
