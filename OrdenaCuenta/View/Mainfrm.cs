using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;



namespace OrdenaCuenta
{
    // todo formulario debe heredar de material form para tomar su disenio 
    public partial class Mainfrm : MaterialForm 
    {
        private int childFormNumber = 0;

        UsuarioController usucon = new UsuarioController();
        UsuarioModel usumod = new UsuarioModel();
      

        public Mainfrm()
        {
            InitializeComponent();
            //  this.IsMdiContainer = true;

            // se llama la clase material para darle estilo al formulario la cual se encuentra en la carpeta utilidades
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);
         
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Mainfrm childForm = new Mainfrm();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            usumod.usuario = "rfune3";

            DataTable dataTable =  usucon.getusuariomenu(usumod);

            foreach (DataRow menuItem in dataTable.Rows)
            {
                string nombreMenu = menuItem["Nombre"].ToString(); // Reemplaza "NombreMenu" con el nombre real de la columna.
                string icono  = menuItem["icono"].ToString(); // Reemplaza "NombreMenu" con el nombre real de la columna.



                TabPage topLevelMenuItem = new TabPage(nombreMenu);
               topLevelMenuItem.ImageKey = icono;
              materialTabControl1.TabPages.Add(topLevelMenuItem);

                  topLevelMenuItem.Name = "TabPage_" + nombreMenu;

                //     materialTabControl1.TabPages.Add(topLevelMenuItem);

                //// Agrega un manejador de eventos al evento Click del MaterialTabPage.
                topLevelMenuItem.Click += (clickedTabPage, eventArgs) =>
                {
                    // Aquí abres el formulario que deseas cuando se hace clic en el MaterialTabPage.
                    string tabPageName = topLevelMenuItem.Name;

                    // Lógica para abrir el formulario en función del tabPageName.
                    if (tabPageName == "TabPage_Inicio")
                    {
                        // Abre el formulario correspondiente al Nombre1.
                        // Por ejemplo:
                        Partidafrm form1 = new Partidafrm();
                        form1.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Nombre2")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        Partidafrm form1 = new Partidafrm();
                        form1.ShowDialog();

                    }
                    // Agrega más casos según tus necesidades.

                };

            }

        }

        private void AbrirFormularioSecundario(Form formularioSecundario, string tituloPestaña )
        {

            TabPage tabPage = new TabPage(tituloPestaña);
            formularioSecundario.TopLevel = false;
            formularioSecundario.FormBorderStyle = FormBorderStyle.None;
            formularioSecundario.Dock = DockStyle.Fill;

            tabPage.Controls.Add(formularioSecundario);
            materialTabControl1.TabPages.Add(tabPage);

            formularioSecundario.Show();


        }



        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialTabControl1.SelectedIndex)
            {
                case 0: // Índice de la primera pestaña
                    Cuentasfrm form1 = new Cuentasfrm(); // Reemplaza Form1 con el nombre de tu formulario               
                    form1.Show();
                    break;
                case 1: // Índice de la segunda pestaña

                    Form1 forms = new Form1();

                    AbrirFormularioSecundario(forms , "tabPage2");

                    break;
                    // Agrega más casos para otras pestañas si es necesario
            }
        }
    }
}
