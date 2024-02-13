using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using Negocio;

namespace AppFinal
{
    public partial class frmNuevaCat : Form
    {
        public frmNuevaCat()
        {
            InitializeComponent();
        }
        public frmNuevaCat(Button boton)
        {
            InitializeComponent();
            lblTitulo.Text = "Nueva Marca";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categorias nuevo = new Categorias();
           
            MarcaNegocio marcaneg = new MarcaNegocio();
            Marcas nuevamarca = new Marcas();
            try
            {
                if (lblTitulo.Text== "Nueva Marca")
                {
                    nuevamarca.Descripcion = txtDescripcion.Text;
                    marcaneg.Agregar(nuevamarca);
                    MessageBox.Show("Marca agregada correctamente", "NUEVA MARCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Text = "";
                    this.Close();

                }
                else
                {
                    nuevo.Descripcion = txtDescripcion.Text;
                    negocio.AgregarCat(nuevo);
                    MessageBox.Show("Categoria agregada correctamente", "NUEVA CATEGORIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Text = "";
                    this.Close();

                }


            }
            catch ( Exception ex )
            { 

                throw ex ;
            }
        }
        //Drag Form para que se mueva la app desde el PanelSuperior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmNuevaCat_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState =FormWindowState.Minimized;
        }
    }
}
