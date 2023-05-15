using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio13
{
    public class Producto
    {
        string codigoProducto;
        string nombreProducto;
        string descripcionProducto;
        double precioCompra;
        double precioVenta;

        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
    }
}