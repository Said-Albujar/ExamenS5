using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenS5
{
    internal class Tienda
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var producto in productos)
            {
                total += producto.Precio;
            }
            return total;
        }

        public void MostrarContenido()
        {
            Console.WriteLine("Contenido del carrito de compras:");
            foreach (var producto in productos)
            {
                Console.WriteLine($"{producto.ObtenerCaracteristicas()}");
            }
            Console.WriteLine($"Precio Total: {CalcularTotal():C}");
        }

        public void LimpiarCarrito()
        {
            productos.Clear();
        }
    }
}
