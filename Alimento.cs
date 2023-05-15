using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio13
{
    public class Alimento : Producto
    {
        string fechaVencimiento;
        string unidadMedida;

        public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
    }
}