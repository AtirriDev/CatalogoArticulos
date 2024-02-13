
namespace AppFinal
{
    partial class frmAgregarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.lblTituloVentana = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.panellateral = new System.Windows.Forms.Panel();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.bntAgregarMarca = new System.Windows.Forms.Button();
            this.btnCargarImagen = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelSuperior.SuspendLayout();
            this.panellateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Black;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargar.FlatAppearance.BorderSize = 2;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(78, 473);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(117, 64);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Articulo";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(271, 473);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 64);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.lblTituloVentana);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(832, 39);
            this.panelSuperior.TabIndex = 3;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(788, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 48);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 30;
            this.btnMinimizar.Location = new System.Drawing.Point(748, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(19, 27);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.Depth = 0;
            this.lblTituloVentana.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloVentana.Location = new System.Drawing.Point(12, 9);
            this.lblTituloVentana.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(109, 19);
            this.lblTituloVentana.TabIndex = 4;
            this.lblTituloVentana.Text = "Nuevo Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = " Url Imagen:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(247, 88);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 20);
            this.txtCodigo.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(146, 201);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(270, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(221, 264);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(195, 21);
            this.cmbCategoria.TabIndex = 14;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(221, 326);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(195, 21);
            this.cmbMarca.TabIndex = 15;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(122, 375);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(236, 20);
            this.txtImagen.TabIndex = 16;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(247, 417);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(169, 20);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // panellateral
            // 
            this.panellateral.BackColor = System.Drawing.Color.White;
            this.panellateral.Controls.Add(this.pctImagen);
            this.panellateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panellateral.Location = new System.Drawing.Point(432, 39);
            this.panellateral.Name = "panellateral";
            this.panellateral.Size = new System.Drawing.Size(400, 510);
            this.panellateral.TabIndex = 18;
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(9, 8);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(377, 489);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImagen.TabIndex = 0;
            this.pctImagen.TabStop = false;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.Black;
            this.btnAgregarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 2;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(180, 264);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(35, 24);
            this.btnAgregarCategoria.TabIndex = 20;
            this.btnAgregarCategoria.Text = "+";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // bntAgregarMarca
            // 
            this.bntAgregarMarca.BackColor = System.Drawing.Color.Black;
            this.bntAgregarMarca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntAgregarMarca.FlatAppearance.BorderSize = 2;
            this.bntAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAgregarMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAgregarMarca.ForeColor = System.Drawing.Color.White;
            this.bntAgregarMarca.Location = new System.Drawing.Point(180, 323);
            this.bntAgregarMarca.Name = "bntAgregarMarca";
            this.bntAgregarMarca.Size = new System.Drawing.Size(35, 24);
            this.bntAgregarMarca.TabIndex = 21;
            this.bntAgregarMarca.Text = "+";
            this.bntAgregarMarca.UseVisualStyleBackColor = false;
            this.bntAgregarMarca.Click += new System.EventHandler(this.bntAgregarMarca_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnCargarImagen.IconColor = System.Drawing.Color.Black;
            this.btnCargarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarImagen.IconSize = 30;
            this.btnCargarImagen.Location = new System.Drawing.Point(364, 364);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(52, 31);
            this.btnCargarImagen.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnCargarImagen, "Haga click u oprima la tecla tab para visualizar la imagen elegida ");
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(832, 549);
            this.Controls.Add(this.bntAgregarMarca);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.panellateral);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panellateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelSuperior;
        private MaterialSkin.Controls.MaterialLabel lblTituloVentana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panellateral;
        private System.Windows.Forms.PictureBox pctImagen;
        private FontAwesome.Sharp.IconButton btnCargarImagen;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button bntAgregarMarca;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}