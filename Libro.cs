using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio13
{
    public class Libro : Producto
    {
        string editorial;
        string categoria;
        string autor;

        public string Editorial { get => editorial; set => editorial = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}