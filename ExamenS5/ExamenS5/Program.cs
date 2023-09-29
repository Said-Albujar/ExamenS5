using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tienda tienda = new Tienda();

            List<Producto> productosDisponibles = new List<Producto>
        {
            new ProductoTela("Camiseta de algodón", 15.99, "Mediana", "Algodón", "Azul"),
            new ProductoTela("Bufanda de lana", 9.99, "Grande", "Lana", "Rojo"),
            new ProductoArcilla("Jarrón de cerámica", 29.99, 500, "Grande", "Blanco"),
            new ProductoArcilla("Taza de cerámica", 12.99, 250, "Pequeña", "Verde")
        };

            while (true)
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Agregar producto al carrito");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar la compra");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Lista de productos disponibles:");
                        for (int i = 0; i < productosDisponibles.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {productosDisponibles[i].Nombre}");
                        }

                        Console.Write("Seleccione el número del producto que desea agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int seleccion))
                        {
                            if (seleccion >= 1 && seleccion <= productosDisponibles.Count)
                            {
                                Producto productoSeleccionado = productosDisponibles[seleccion - 1];
                                tienda.AgregarProducto(productoSeleccionado);
                                Console.WriteLine($"Producto '{productoSeleccionado.Nombre}' agregado al carrito.");
                            }
                            else
                            {
                                Console.WriteLine("Número de producto no válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Ingrese un número.");
                        }
                        break;


                    case "2":
                        tienda.MostrarContenido();
                        break;

                    case "3":
                        Console.WriteLine("Compra finalizada. Detalles de la compra:");
                        tienda.MostrarContenido();
                        Console.WriteLine("¿Desea crear un nuevo carrito de compras? (S/N)");
                        string respuesta = Console.ReadLine();
                        if (respuesta.ToLower() == "s")
                        {
                            tienda.LimpiarCarrito();
                        }
                        else
                        {
                            Console.WriteLine("Gracias por comprar. Hasta luego.");
                            return;
                        }
                        break;

                    case "4":
                        Console.WriteLine("Gracias por usar nuestro sistema. Hasta luego.");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
}
