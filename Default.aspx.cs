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
        List<Alimento> alimentos = new List<Alimento>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //productos = Leer();
        }

        protected void ButtonRegistrarProducto_Click(object sender, EventArgs e)
        {
            if (productos == null)
            {
                productos = new List<Producto>();
            }
            else
            {
                Producto productoExiste = productos.Find(u => u.CodigoProducto == TextBoxCodigoProducto.Text);
                if (productoExiste == null)
                {
                    Producto productoNuevo = new Producto();
                    

                    if (DropDownListTipoProducto.SelectedValue == "Alimento")
                    {
                        Alimento alimentoNuevo = new Alimento();

                        alimentoNuevo.CodigoProducto = TextBoxCodigoProducto.Text;
                        alimentoNuevo.NombreProducto = TextBoxNombreProducto.Text;
                        alimentoNuevo.DescripcionProducto = TextBoxDescripcionProducto.Text;
                        alimentoNuevo.PrecioCompra = Convert.ToDouble(TextBoxPrecioCompra.Text);
                        alimentoNuevo.PrecioVenta = Convert.ToDouble(TextBoxPrecioVenta.Text);

                        alimentoNuevo.FechaVencimiento = TextBoxAFechaVencimiento.Text;
                        alimentoNuevo.UnidadMedida = TextBoxAUnidadMedida.Text;

                        alimentos.Add(alimentoNuevo);
                    } else if (DropDownListTipoProducto.SelectedValue == "Electronico")
                    {

                    } else if (DropDownListTipoProducto.SelectedValue == "Libros")
                    {

                    }
                    productos.Add(productoNuevo);
                }
            }
            Grabar();
        }

        private List<Alimento> Leer()
        {
            List<Alimento> listaAlimentos = new List<Alimento>();
            string archivo = Server.MapPath("Productos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaAlimentos = JsonConvert.DeserializeObject<List<Alimento>>(json);

            return listaAlimentos.ToList();
        }

        private void Grabar()
        {
            string json = JsonConvert.SerializeObject(alimentos);
            string archivo = Server.MapPath("Productos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}