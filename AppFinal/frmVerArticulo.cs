using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace AppFinal
{
    public partial class frmVerArticulo : Form
    {
        private Articulos articulo = null;
        public frmVerArticulo()
        {
            InitializeComponent();
        }
        public frmVerArticulo(Articulos articulo )
        {
            InitializeComponent();
            this.articulo = articulo;
           


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmVerArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                

                // validacion para saber si traemos un objeto 
                if (articulo != null)
                {
                    lblCodigo.Text = articulo.CodigoArt;
                    lblNombre.Text = articulo.Nombre;
                    lblDescripcion.Text = articulo.Descripcion;
                    lblMarca.Text = articulo.Marca.Descripcion;
                    lblCategoria.Text = articulo.Categoria.Descripcion;
                    lblPrecio.Text = articulo.Precio.ToString("N2");
                    lblImagen.Text = articulo.Imagen;
                    lblImagen.Visible = false;
                    //Cargamos la imagen 
                    CargaImagen(articulo.Imagen);
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void CargaImagen(string imagen)
        {

            try
            {
                pctImagen.Load(imagen);
            }
            catch (Exception)
            {

                pctImagen.Load("https://www.shutterstock.com/image-vector/image-not-found-grayscale-photo-260nw-1737334631.jpg");
            }



        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            CargaImagen(lblImagen.Text);
        }
        //Drag Form para que se mueva la app desde el PanelSuperior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
