using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio13
{
    public class Electronico : Producto
    {
        int tiempoGarantia;
        int voltajeUtiliza;

        public int TiempoGarantia { get => tiempoGarantia; set => tiempoGarantia = value; }
        public int VoltajeUtiliza { get => voltajeUtiliza; set => voltajeUtiliza = value; }
    }
}