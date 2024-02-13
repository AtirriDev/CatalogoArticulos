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
    public partial class frmVentanaPrincipal : Form
    {
        public List<Articulos> listaArt;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelSuperior.Height = 800;
            btnDesplegar2.Visible = false;
            pctLogoSup.Visible = false;
            timer1.Start();
            CargarDgv();
            cmbCampo.Items.Add("Descripcion");
            cmbCampo.Items.Add("Categoria");
            cmbCampo.Items.Add("Precio");




        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            panelSuperior.Height = 80;
            btnDesplegar2.Visible = true;
            btnDesplegar.Visible = false;
            pctLogoSup.Visible = true;
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panelSuperior.Height = 800;
            btnDesplegar.Visible = true;
            btnDesplegar2.Visible = false;
            pctLogoSup.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿ Esta seguro que quiere cerrar la aplicacion ?","CERRAR" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                
                this.Close();
                
            }
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void trkPrecio_Scroll(object sender, EventArgs e)
        {
            lblPrecioHasta.Text = " $"+ trkPrecio.Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo ventana = new frmAgregarArticulo();
            
            ventana.ShowDialog();

            CargarDgv();
        }


        private void CargarDgv() 
        {
           
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                // Cargamos la lista 
                listaArt = negocio.listar();

                //Pasamos los datos a la grilla mediante Data Source

                dgvArticulos.DataSource = listaArt;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Imagen"].Visible = false;
                dgvArticulos.Columns["Descripcion"].Width = 200;
                dgvArticulos.Columns["Nombre"].Width = 200;
                dgvArticulos.Columns["Marca"].Width = 138;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N0";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // configuramos que tome el objeto de la fila seleccionada mediante CurrentRow de la grilla preguntando si es distinto de null
            if (dgvArticulos.CurrentRow != null)
            {
                //creamos un objeto de la clase que vamos a utilizar
                Articulos seleccionado;
                // le asignamos la fila 
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                //Abrimos el frm Modificar que enrealidad es el agregar reutilizado y con parametro
                frmAgregarArticulo ventana = new frmAgregarArticulo(seleccionado);
                ventana.ShowDialog();

                CargarDgv();

               
            }
            else
            {
                MessageBox.Show("Por favor seleccione el articulo a modificar", "MODIFICAR ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                //creamos un objeto de la clase que vamos a utilizar
                Articulos seleccionado;
                // le asignamos la fila 
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;


                
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listafiltro;
            string filtro = txtBusqueda.Text;
            if (filtro.Length >= 3)
            {
                listafiltro = listaArt.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Marca.ToString().ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listafiltro = listaArt;
            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltro;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Width = 200;
            dgvArticulos.Columns["Nombre"].Width = 200;
            dgvArticulos.Columns["Marca"].Width = 138;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N0";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            
            if (dgvArticulos.CurrentRow != null)
            {
                
                Articulos seleccionado;
                
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
               


                //Abrimos el frm ver articulo 
               
                frmVerArticulo ventana = new frmVerArticulo(seleccionado);
                ventana.Show(); // uso show y no show dialog para poder abrir varios articulos por si se quiere comparar caracteristicas me parece mas funcional 

                // me faltaria validar si el articulo especifico ya esta abierto para q no abra el mismo 2 veces , le di vueltas pero no logro descrifrar esa funcionalidad
                // si podes en la devolucion del trabajo podrias decirme como podria ser viable esa funcionalidad

                CargarDgv();






            }
            else
            {
                MessageBox.Show("Por favor seleccione el articulo a modificar ", "MODIFICAR ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CargarCombos()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio cat = new CategoriaNegocio();
            try
            {
                cmbCriterio.DataSource = cat.Listar();
                cmbCriterio.ValueMember = "IdCategoria";
                cmbCriterio.DisplayMember = "Descripcion";

                cmbCampo.DataSource = marca.Listar();
                cmbCampo.ValueMember = "IdMarca";
                cmbCampo.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }










        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            if (cmbCampo.Text != "" && cmbCriterio.Text !="" && txtFiltro.Text != "" || trkPrecio.Value != 0 )
            {
                try
                {
                    string campo = cmbCampo.SelectedItem.ToString();
                    string criterio = cmbCriterio.SelectedItem.ToString();
                    string filtro = txtFiltro.Text;
                    decimal rango = trkPrecio.Value;
                    dgvArticulos.DataSource = negocio.Filtar(campo, criterio, filtro, rango);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                    
                }
            }
            else if (cmbCriterio.Text == "Igual a" && txtFiltro.Text == "")
            {
                MessageBox.Show("Por favor ponga un numero en la casilla de filtro ", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvArticulos.DataSource = negocio.listar();
            }
            else if (cmbCriterio.Text == "Mayor a" || cmbCriterio.Text == "Menor a" && trkPrecio.Value == 0)
            {
                MessageBox.Show("Por favor seleccione un valor en la barra de precios ", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvArticulos.DataSource = negocio.listar();
            }
            else
            {
                MessageBox.Show("Por favor seleccione los campos para poder realizar la busqueda ", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                dgvArticulos.DataSource = negocio.listar();
            }
           
            
           
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cmbCampo.SelectedItem.ToString();
            if (opcion == "Descripcion" || opcion == "Categoria")
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Comienza con");
                cmbCriterio.Items.Add("Termina con");
                cmbCriterio.Items.Add("Contiene con");
                txtFiltro.Enabled = true;
            }
            else
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Mayor a");
                cmbCriterio.Items.Add("Menor a");
                cmbCriterio.Items.Add("Igual a");
                txtFiltro.Enabled = false;
            }
        }

        private void cmbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cmbCriterio.SelectedItem.ToString();
            if (opcion== "Mayor a")
            {
                lbltkrprecio.Text = " Precio Desde:";
                trkPrecio.Enabled = true;
                txtFiltro.Enabled = false;

            }
            else if (opcion== "Menor a")
            {
                lbltkrprecio.Text = "Precio Hasta:";
                trkPrecio.Enabled = true;
                txtFiltro.Enabled = false;

            }
            else
            {
                lbltkrprecio.Text = "";
                trkPrecio.Enabled = false;
                txtFiltro.Enabled = true;
                
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    //creamos un objeto de la clase que vamos a utilizar
                    Articulos seleccionado;
                    // le asignamos la fila 
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                    DialogResult pregunta = MessageBox.Show("¿Seguro desea eliminar este articulo? ", "ELIMINACION ARTICULO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (pregunta == DialogResult.Yes)
                    {
                        negocio.Eliminar(seleccionado.Id);
                        MessageBox.Show("Articulo eliminado correctamente ", "ELIMINACION ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                    }
                   


                }
                else
                {
                    MessageBox.Show("Por favor seleccione el articulo a eliminar ", "ELIMINACION ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbCriterio.Text== "Igual a")
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                txtFiltro.MaxLength = 7;
            }
           
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
