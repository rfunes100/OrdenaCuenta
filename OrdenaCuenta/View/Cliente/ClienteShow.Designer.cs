namespace OrdenaCuenta.View.Cliente
{
    partial class ClienteShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteShow));
            this.lsclientes = new MaterialSkin.Controls.MaterialListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.segundoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.segundoApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaIngreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moneda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btagregar = new MaterialSkin.Controls.MaterialButton();
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.btneliminar = new MaterialSkin.Controls.MaterialButton();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.Idtxt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsclientes
            // 
            this.lsclientes.AutoSizeTable = false;
            this.lsclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsclientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsclientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.segundoNombre,
            this.Apellido,
            this.segundoApellido,
            this.email,
            this.FechaIngreso,
            this.Telefono,
            this.Abono,
            this.moneda,
            this.Idtxt,
            this.Direccion});
            this.lsclientes.Depth = 0;
            this.lsclientes.FullRowSelect = true;
            this.lsclientes.HideSelection = false;
            this.lsclientes.Location = new System.Drawing.Point(26, 191);
            this.lsclientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsclientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsclientes.MouseState = MaterialSkin.MouseState.OUT;
            this.lsclientes.Name = "lsclientes";
            this.lsclientes.OwnerDraw = true;
            this.lsclientes.Size = new System.Drawing.Size(753, 194);
            this.lsclientes.TabIndex = 0;
            this.lsclientes.UseCompatibleStateImageBehavior = false;
            this.lsclientes.View = System.Windows.Forms.View.Details;
            this.lsclientes.ItemActivate += new System.EventHandler(this.lsclientes_ItemActivate);
            this.lsclientes.Click += new System.EventHandler(this.lsclientes_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 100;
            // 
            // segundoNombre
            // 
            this.segundoNombre.Text = "Seg Nombre";
            this.segundoNombre.Width = 130;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 100;
            // 
            // segundoApellido
            // 
            this.segundoApellido.Text = "Seg Apellido";
            this.segundoApellido.Width = 130;
            // 
            // email
            // 
            this.email.Text = "email";
            this.email.Width = 200;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Text = "FechaIngreso";
            this.FechaIngreso.Width = 120;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            this.Telefono.Width = 100;
            // 
            // Abono
            // 
            this.Abono.Text = "Abono";
            this.Abono.Width = 120;
            // 
            // moneda
            // 
            this.moneda.Text = "moneda";
            // 
            // btagregar
            // 
            this.btagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btagregar.Depth = 0;
            this.btagregar.HighEmphasis = true;
            this.btagregar.Icon = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_1495461;
            this.btagregar.Location = new System.Drawing.Point(552, 405);
            this.btagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btagregar.Name = "btagregar";
            this.btagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btagregar.Size = new System.Drawing.Size(116, 36);
            this.btagregar.TabIndex = 8;
            this.btagregar.Text = "Agregar";
            this.btagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btagregar.UseAccentColor = false;
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = global::OrdenaCuenta.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btneditar.Location = new System.Drawing.Point(297, 405);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(99, 36);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneditar.UseAccentColor = false;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneliminar.Depth = 0;
            this.btneliminar.HighEmphasis = true;
            this.btneliminar.Icon = global::OrdenaCuenta.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btneliminar.Location = new System.Drawing.Point(86, 405);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneliminar.Size = new System.Drawing.Size(116, 36);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneliminar.UseAccentColor = false;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(272, 124);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(241, 50);
            this.txtnombre.TabIndex = 9;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = null;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // Idtxt
            // 
            this.Idtxt.Text = "Id";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(83, 136);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 34);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 200;
            // 
            // ClienteShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lsclientes);
            this.Name = "ClienteShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Clientes";
            this.Load += new System.EventHandler(this.ClienteShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lsclientes;
        private MaterialSkin.Controls.MaterialButton btagregar;
        private MaterialSkin.Controls.MaterialButton btneditar;
        private MaterialSkin.Controls.MaterialButton btneliminar;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader segundoNombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader segundoApellido;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader FechaIngreso;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Abono;
        private System.Windows.Forms.ColumnHeader moneda;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private System.Windows.Forms.ColumnHeader Idtxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Direccion;
    }
}