using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio13
{
    public partial class _Default : Page
    {
        List<Producto> productos = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {
            productos = Leer();
        }

        protected void ButtonRegistrarProducto_Click(object sender, EventArgs e)
        {

        }

        private List<Producto> Leer()
        {
            List<Producto> listaProductos = new List<Producto>();
            string archivo = Server.MapPath("Productos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaProductos = JsonConvert.DeserializeObject<List<Producto>>(json);

            return listaProductos;
        }

        private void Grabar()
        {
            string json = JsonConvert.SerializeObject(productos);
            string archivo = Server.MapPath("Productos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}