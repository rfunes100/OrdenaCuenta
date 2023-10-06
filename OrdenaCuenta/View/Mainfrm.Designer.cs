namespace OrdenaCuenta
{
    partial class Mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbcuentas = new System.Windows.Forms.TabPage();
            this.tbmoneda = new System.Windows.Forms.TabPage();
            this.imglistmenu = new System.Windows.Forms.ImageList(this.components);
            this.tbhismonedas = new System.Windows.Forms.TabPage();
            this.statusStrip.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(4, 528);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(835, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbcuentas);
            this.materialTabControl1.Controls.Add(this.tbmoneda);
            this.materialTabControl1.Controls.Add(this.tbhismonedas);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imglistmenu;
            this.materialTabControl1.Location = new System.Drawing.Point(4, 79);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(835, 449);
            this.materialTabControl1.TabIndex = 4;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tbcuentas
            // 
            this.tbcuentas.BackColor = System.Drawing.Color.White;
            this.tbcuentas.ImageKey = "1455739708_Kitchen_Bold_Line_Color_Mix-04_icon-icons.com_53405.png";
            this.tbcuentas.Location = new System.Drawing.Point(4, 39);
            this.tbcuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcuentas.Name = "tbcuentas";
            this.tbcuentas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcuentas.Size = new System.Drawing.Size(827, 406);
            this.tbcuentas.TabIndex = 0;
            this.tbcuentas.Text = "Catalogo Contable";
            this.tbcuentas.ToolTipText = "Catalogo Contable";
            // 
            // tbmoneda
            // 
            this.tbmoneda.ImageKey = "dollar-coin-money_icon-icons.com_56177.png";
            this.tbmoneda.Location = new System.Drawing.Point(4, 39);
            this.tbmoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbmoneda.Name = "tbmoneda";
            this.tbmoneda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbmoneda.Size = new System.Drawing.Size(827, 406);
            this.tbmoneda.TabIndex = 1;
            this.tbmoneda.Text = "Monedas";
            this.tbmoneda.ToolTipText = "Catalogo Monedas";
            this.tbmoneda.UseVisualStyleBackColor = true;
            // 
            // imglistmenu
            // 
            this.imglistmenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistmenu.ImageStream")));
            this.imglistmenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistmenu.Images.SetKeyName(0, "home_house_3526.png");
            this.imglistmenu.Images.SetKeyName(1, "note-task-comment-message-edit-write_108613 (1).png");
            this.imglistmenu.Images.SetKeyName(2, "business_application_addmale_useradd_insert_add_user_client_2312.png");
            this.imglistmenu.Images.SetKeyName(3, "1455739708_Kitchen_Bold_Line_Color_Mix-04_icon-icons.com_53405.png");
            this.imglistmenu.Images.SetKeyName(4, "dollar-coin-money_icon-icons.com_56177.png");
            this.imglistmenu.Images.SetKeyName(5, "1489436636-coindollarcurrencymoney_81873.png");
            // 
            // tbhismonedas
            // 
            this.tbhismonedas.ImageKey = "1489436636-coindollarcurrencymoney_81873.png";
            this.tbhismonedas.Location = new System.Drawing.Point(4, 39);
            this.tbhismonedas.Name = "tbhismonedas";
            this.tbhismonedas.Padding = new System.Windows.Forms.Padding(3);
            this.tbhismonedas.Size = new System.Drawing.Size(827, 406);
            this.tbhismonedas.TabIndex = 2;
            this.tbhismonedas.Text = "HIstorico Monedas";
            this.tbhismonedas.ToolTipText = "Historico de valores de moneda";
            this.tbhismonedas.UseVisualStyleBackColor = true;
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.statusStrip);
            this.DrawerTabControl = this.materialTabControl1;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mainfrm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainfrm";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbcuentas;
        private System.Windows.Forms.TabPage tbmoneda;
        private System.Windows.Forms.ImageList imglistmenu;
        private System.Windows.Forms.TabPage tbhismonedas;
    }
}



