
namespace AppFinal
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDesplegar2 = new FontAwesome.Sharp.IconButton();
            this.btnDesplegar = new FontAwesome.Sharp.IconButton();
            this.pctLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.pctLogoSup = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecioHasta = new MaterialSkin.Controls.MaterialLabel();
            this.trkPrecio = new System.Windows.Forms.TrackBar();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.lbltkrprecio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFiltro = new FontAwesome.Sharp.IconButton();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnVerArticulo = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoSup)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.PanelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Black;
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.lblTime);
            this.panelSuperior.Controls.Add(this.btnDesplegar2);
            this.panelSuperior.Controls.Add(this.btnDesplegar);
            this.panelSuperior.Controls.Add(this.pctLogoPrincipal);
            this.panelSuperior.Controls.Add(this.pctLogoSup);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1200, 80);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.Location = new System.Drawing.Point(1016, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(75, 58);
            this.btnMinimizar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnMinimizar, "Minimizar aplicacion");
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.Location = new System.Drawing.Point(1106, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 58);
            this.btnCerrar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar aplicacion");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTime.Location = new System.Drawing.Point(205, 654);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(593, 112);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "dsadsasdas";
            // 
            // btnDesplegar2
            // 
            this.btnDesplegar2.FlatAppearance.BorderSize = 0;
            this.btnDesplegar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDesplegar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDesplegar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegar2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnDesplegar2.IconColor = System.Drawing.Color.White;
            this.btnDesplegar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesplegar2.Location = new System.Drawing.Point(12, 24);
            this.btnDesplegar2.Name = "btnDesplegar2";
            this.btnDesplegar2.Size = new System.Drawing.Size(75, 58);
            this.btnDesplegar2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnDesplegar2, "haga click para activar el modo ocultar informacion");
            this.btnDesplegar2.UseVisualStyleBackColor = true;
            this.btnDesplegar2.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnDesplegar
            // 
            this.btnDesplegar.FlatAppearance.BorderSize = 0;
            this.btnDesplegar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDesplegar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDesplegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnDesplegar.IconColor = System.Drawing.Color.White;
            this.btnDesplegar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesplegar.Location = new System.Drawing.Point(12, 730);
            this.btnDesplegar.Name = "btnDesplegar";
            this.btnDesplegar.Size = new System.Drawing.Size(75, 58);
            this.btnDesplegar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDesplegar, "Haga click para visualizar la App");
            this.btnDesplegar.UseVisualStyleBackColor = true;
            this.btnDesplegar.Click += new System.EventHandler(this.btnDesplegar_Click);
            // 
            // pctLogoPrincipal
            // 
            this.pctLogoPrincipal.Image = global::AppFinal.Properties.Resources.Logo_moderno_de_tecnología_azul_y_verde;
            this.pctLogoPrincipal.Location = new System.Drawing.Point(387, 224);
            this.pctLogoPrincipal.Name = "pctLogoPrincipal";
            this.pctLogoPrincipal.Size = new System.Drawing.Size(411, 353);
            this.pctLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogoPrincipal.TabIndex = 3;
            this.pctLogoPrincipal.TabStop = false;
            // 
            // pctLogoSup
            // 
            this.pctLogoSup.Image = global::AppFinal.Properties.Resources.Logo_moderno_de_tecnología_azul_y_verde;
            this.pctLogoSup.Location = new System.Drawing.Point(37, -47);
            this.pctLogoSup.Name = "pctLogoSup";
            this.pctLogoSup.Size = new System.Drawing.Size(235, 194);
            this.pctLogoSup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoSup.TabIndex = 4;
            this.pctLogoSup.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.lblPrecioHasta);
            this.groupBox1.Controls.Add(this.trkPrecio);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Controls.Add(this.cmbCriterio);
            this.groupBox1.Controls.Add(this.lbltkrprecio);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Location = new System.Drawing.Point(26, 595);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(537, 47);
            this.txtFiltro.MaxLength = 30;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(141, 20);
            this.txtFiltro.TabIndex = 19;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(483, 48);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(48, 19);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "Filtro:";
            // 
            // lblPrecioHasta
            // 
            this.lblPrecioHasta.AutoSize = true;
            this.lblPrecioHasta.Depth = 0;
            this.lblPrecioHasta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrecioHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecioHasta.Location = new System.Drawing.Point(799, 78);
            this.lblPrecioHasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioHasta.Name = "lblPrecioHasta";
            this.lblPrecioHasta.Size = new System.Drawing.Size(25, 19);
            this.lblPrecioHasta.TabIndex = 17;
            this.lblPrecioHasta.Text = "$0";
            // 
            // trkPrecio
            // 
            this.trkPrecio.BackColor = System.Drawing.Color.White;
            this.trkPrecio.Location = new System.Drawing.Point(793, 34);
            this.trkPrecio.Maximum = 1000000;
            this.trkPrecio.Name = "trkPrecio";
            this.trkPrecio.Size = new System.Drawing.Size(192, 45);
            this.trkPrecio.TabIndex = 16;
            this.trkPrecio.TickFrequency = 10000;
            this.trkPrecio.Scroll += new System.EventHandler(this.trkPrecio_Scroll);
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(90, 48);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(136, 21);
            this.cmbCampo.TabIndex = 14;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(326, 47);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(136, 21);
            this.cmbCriterio.TabIndex = 13;
            this.cmbCriterio.SelectedIndexChanged += new System.EventHandler(this.cmbCriterio_SelectedIndexChanged);
            // 
            // lbltkrprecio
            // 
            this.lbltkrprecio.AutoSize = true;
            this.lbltkrprecio.Depth = 0;
            this.lbltkrprecio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbltkrprecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltkrprecio.Location = new System.Drawing.Point(693, 46);
            this.lbltkrprecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbltkrprecio.Name = "lbltkrprecio";
            this.lbltkrprecio.Size = new System.Drawing.Size(104, 19);
            this.lbltkrprecio.TabIndex = 12;
            this.lbltkrprecio.Text = " Precio Hasta:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 50);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Campo:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(242, 49);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Criterio:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.Black;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFiltro.IconColor = System.Drawing.Color.Black;
            this.btnFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltro.Location = new System.Drawing.Point(1015, 30);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(95, 68);
            this.btnFiltro.TabIndex = 8;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(25, 68);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(882, 503);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(542, 36);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Busqueda Rapida:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 574);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Busqueda por Filtros:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.Controls.Add(this.materialLabel3);
            this.PanelCentral.Controls.Add(this.txtBusqueda);
            this.PanelCentral.Controls.Add(this.materialLabel2);
            this.PanelCentral.Controls.Add(this.materialLabel1);
            this.PanelCentral.Controls.Add(this.dgvArticulos);
            this.PanelCentral.Controls.Add(this.groupBox1);
            this.PanelCentral.Controls.Add(this.btnEliminar);
            this.PanelCentral.Controls.Add(this.btnModificar);
            this.PanelCentral.Controls.Add(this.btnAgregar);
            this.PanelCentral.Controls.Add(this.btnVerArticulo);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(0, 80);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1200, 720);
            this.PanelCentral.TabIndex = 1;
            this.PanelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentral_Paint);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(22, 36);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(210, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Listado de todos los articulos";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(676, 35);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(226, 20);
            this.txtBusqueda.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtBusqueda, "Busqueda rapida filtra por Nombre y Marca");
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(904, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(296, 88);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.Location = new System.Drawing.Point(904, 201);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(296, 88);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(904, 68);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(296, 88);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerArticulo
            // 
            this.btnVerArticulo.BackColor = System.Drawing.Color.Black;
            this.btnVerArticulo.FlatAppearance.BorderSize = 0;
            this.btnVerArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArticulo.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArticulo.ForeColor = System.Drawing.Color.White;
            this.btnVerArticulo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerArticulo.IconColor = System.Drawing.Color.Black;
            this.btnVerArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArticulo.Location = new System.Drawing.Point(901, 483);
            this.btnVerArticulo.Name = "btnVerArticulo";
            this.btnVerArticulo.Size = new System.Drawing.Size(296, 88);
            this.btnVerArticulo.TabIndex = 5;
            this.btnVerArticulo.Text = "Ver Articulo";
            this.btnVerArticulo.UseVisualStyleBackColor = false;
            this.btnVerArticulo.Click += new System.EventHandler(this.btnVerArticulo_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoSup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.PanelCentral.ResumeLayout(false);
            this.PanelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private FontAwesome.Sharp.IconButton btnDesplegar;
        private FontAwesome.Sharp.IconButton btnDesplegar2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pctLogoPrincipal;
        
        private System.Windows.Forms.PictureBox pctLogoSup;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnFiltro;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnVerArticulo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.TextBox txtBusqueda;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TrackBar trkPrecio;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private MaterialSkin.Controls.MaterialLabel lbltkrprecio;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblPrecioHasta;
        private System.Windows.Forms.TextBox txtFiltro;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

