using MaterialSkin.Controls;
using OrdenaCuenta.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.Usuariofrm
{
    public partial class UsuarioAdd : MaterialForm
    {
        public UsuarioAdd()
        {
            InitializeComponent();
        }

        private void UsuarioAdd_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);


        }
    }
}
