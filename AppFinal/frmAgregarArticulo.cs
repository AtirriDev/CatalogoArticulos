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
    public partial class frmAgregarArticulo : Form
    {

        private Articulos articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulos articulo )
        {
            InitializeComponent();
            this.articulo = articulo;
            lblTituloVentana.Text = "Modificar Articulo";
            btnCargar.Text="Modificar";
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
        //Drag Form para que se mueva la app desde el PanelSuperior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                
                // validacion para saber si traemos un objeto para modificar y debemos mostrar sus datos 
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArt;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.Imagen;
                    //Cargamos la imagen 
                    CargaImagen(articulo.Imagen);
                    txtPrecio.Text = articulo.Precio.ToString("N2");

                    cmbCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    cmbMarca.SelectedValue = articulo.Marca.IdMarca;
                }
                else
                {
                    cmbCategoria.SelectedIndex = -1;
                    cmbMarca.SelectedIndex = -1;
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }
            

        }
        private void CargarCombos() 
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio cat = new CategoriaNegocio();
            try
            {
                cmbCategoria.DataSource = cat.Listar();
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.DisplayMember = "Descripcion";

                cmbMarca.DataSource = marca.Listar();
                cmbMarca.ValueMember = "IdMarca";
                cmbMarca.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
           
                

            

            
        
        
        
        
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
           

            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                if (articulo== null)
                {
                    articulo = new Articulos();
                }
               

                if (articulo.Id !=0)
                {
                    

                    if (ControlCajas() == true)
                    {
                        articulo.CodigoArt = txtCodigo.Text;
                        articulo.Nombre = txtNombre.Text;
                        articulo.Descripcion = txtDescripcion.Text;
                        articulo.Marca = (Marcas)cmbMarca.SelectedItem;
                        articulo.Categoria = (Categorias)cmbCategoria.SelectedItem;
                        articulo.Imagen = txtImagen.Text;
                        articulo.Precio = Convert.ToDecimal(txtPrecio.Text);

                        DialogResult pregunta = MessageBox.Show("¿ Esta seguro que desea modificar el articulo ?", "MODIFICACION ARTICULO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (pregunta == DialogResult.Yes )
                        {
                            negocio.Modificar(articulo);
                            MessageBox.Show("Articulo modificado correctamente", "MODIFICACION ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCajas();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor completar los campos correspondientes para la carga del articulo", "NUEVO ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                   
                   
                }
                else
                {
                    

                    if (ControlCajas() == true )
                    {
                        articulo.CodigoArt = txtCodigo.Text;
                        articulo.Nombre = txtNombre.Text;
                        articulo.Descripcion = txtDescripcion.Text;
                        articulo.Marca = (Marcas)cmbMarca.SelectedItem;
                        articulo.Categoria = (Categorias)cmbCategoria.SelectedItem;
                        articulo.Imagen = txtImagen.Text;
                        articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                            
                        negocio.Agregar(articulo);
                        MessageBox.Show("Articulo agregado correctamente", "NUEVO ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCajas();
                    }
                    else
                    {
                        MessageBox.Show("Por favor completar los campos correspondientes para la carga del articulo","NUEVO ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                   
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
            CargaImagen(txtImagen.Text);
        }

        private void LimpiarCajas() 
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            txtImagen.Text = "";
            txtPrecio.Text = "";
            CargaImagen(txtImagen.Text);

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmNuevaCat ventana = new frmNuevaCat();
            ventana.ShowDialog();
            CargarCombos();
        }

        private void bntAgregarMarca_Click(object sender, EventArgs e)
        {
            frmNuevaCat ventana = new frmNuevaCat(bntAgregarMarca);
            ventana.ShowDialog();
            CargarCombos();
        }

        private bool ControlCajas() 
        {

            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcion.Text != "" && cmbCategoria.SelectedItem != null && cmbMarca.SelectedItem != null && txtImagen.Text != "" && txtPrecio.Text != "") 
            {
                return  true;
            }
            else
            {
                return  false;
            }


        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (txtImagen.Text== "")
            {
                MessageBox.Show("Por favor complete el campo Url Imagen correspondiente para poder visualizar ","CARGA IMAGEN" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            }
        }
    }
}
