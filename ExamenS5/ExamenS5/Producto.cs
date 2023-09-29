using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenS5
{
    class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public virtual string ObtenerCaracteristicas()
        {
            return $"Nombre: {Nombre}, Precio: {Precio:C}";
        }
    }

    class ProductoTela : Producto
    {
        public string Tamaño { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public ProductoTela(string nombre, double precio, string tamaño, string material, string color)
            : base(nombre, precio)
        {
            Tamaño = tamaño;
            Material = material;
            Color = color;
        }

        public override string ObtenerCaracteristicas()
        {
            return base.ObtenerCaracteristicas() + $", Tamaño: {Tamaño}, Material: {Material}, Color: {Color}";
        }
    }

    class ProductoArcilla : Producto
    {
        public double Peso { get; set; }
        public string Tamaño { get; set; }
        public string Color { get; set; }

        public ProductoArcilla(string nombre, double precio, double peso, string tamaño, string color)
            : base(nombre, precio)
        {
            Peso = peso;
            Tamaño = tamaño;
            Color = color;
        }

        public override string ObtenerCaracteristicas()
        {
            return base.ObtenerCaracteristicas() + $", Peso: {Peso} g, Tamaño: {Tamaño}, Color: {Color}";
        }
    }
}
