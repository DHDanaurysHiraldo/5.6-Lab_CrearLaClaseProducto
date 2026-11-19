namespace _5_6_Lab_CrearLaClaseProducto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Inventario - Lab 5.6 ===\n");

            Producto producto1 = new Producto();
            Producto producto2 = new Producto();
            Producto producto3 = new Producto();


            producto1.Codigo = "P001";
            producto1.Nombre = "Laptop";
            producto1.Precio = 45000m;
            producto1.Cantidad = 3;

            producto2.Codigo = "P002";
            producto2.Nombre = "Mouse inalámbrico";
            producto2.Precio = 100m;
            producto2.Cantidad = 5;

            producto3.Codigo = "P003";
            producto3.Nombre = "Teclado mecánico";
            producto3.Precio = 250m;
            producto3.Cantidad = 0;

            producto1.MostrarInformacion();
            Console.WriteLine($"Valor Total: RD${producto1.CalcularValorTotal():N2}\n");

            producto2.MostrarInformacion();
            Console.WriteLine($"Valor Total: RD${producto2.CalcularValorTotal():N2}\n");

            producto3.MostrarInformacion();
            Console.WriteLine($"Valor Total: RD${producto3.CalcularValorTotal():N2}\n");



            Console.WriteLine("=== Prueba de independencia ===");
            Console.WriteLine("Se modificará SOLO el precio del Producto 1.\n");

            Console.WriteLine("ANTES del cambio:");
            Console.WriteLine($"  Producto 1 ({producto1.Codigo} - {producto1.Nombre}) -> Precio: RD${producto1.Precio:N2}");
            Console.WriteLine($"  Producto 2 ({producto2.Codigo} - {producto2.Nombre}) -> Precio: RD${producto2.Precio:N2}");
            Console.WriteLine($"  Producto 3 ({producto3.Codigo} - {producto3.Nombre}) -> Precio: RD${producto3.Precio:N2}\n");

            producto1.Precio = 40000m;   // solo cambiamos producto1

            Console.WriteLine("DESPUÉS del cambio:");
            Console.WriteLine($"  Producto 1 ({producto1.Codigo} - {producto1.Nombre}) -> Precio: RD${producto1.Precio:N2}  <- modificado");
            Console.WriteLine($"  Producto 2 ({producto2.Codigo} - {producto2.Nombre}) -> Precio: RD${producto2.Precio:N2}  <- sin cambios");
            Console.WriteLine($"  Producto 3 ({producto3.Codigo} - {producto3.Nombre}) -> Precio: RD${producto3.Precio:N2}  <- sin cambios\n");

            Console.WriteLine($"Nuevo valor total del Producto 1: RD${producto1.CalcularValorTotal():N2}");

        }
    }
}
