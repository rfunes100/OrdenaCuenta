﻿using MaterialSkin.Controls;
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
using MaterialSkin;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;

namespace OrdenaCuenta.View
{
    public partial class Partidafrm : MaterialForm
    {
        // Crear un nuevo DateTimePicker

        LibroController librocon = new LibroController();
        CuentaController cuentacon = new CuentaController();
        CorrelativoController correlativocon = new CorrelativoController();
        PartidaController partidacon = new PartidaController();
        CorrelativoController correlacon = new CorrelativoController();

        Partida partidamod = new Partida();
        Correlativo correlamod = new Correlativo();



        string correlativo = null;
        string clasificacioncuenta = "";
        int debe = 0;
        int haber = 0;





        public Partidafrm()
        {
            InitializeComponent();

          

        }


        private void cargarcmb()
        {
            cmblibro.DataSource = librocon.GetLibro();

            cmblibro.DisplayMember = "Descripcion";
            cmblibro.ValueMember = "Id";

            cmbcuenta.DataSource = cuentacon.Getcuentadt();

            cmbcuenta.DisplayMember = "Descripcion";
            cmbcuenta.ValueMember = "Id";

            correlativo = correlativocon.GetCorrelativo (); 

        }


        private void Partidafrm_Load(object sender, EventArgs e)
        {

            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
           
            estilo.frmMaterial(this);

            monthCalendar1.Visible = false;

            this.cargarcmb();

        }

   

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.BringToFront();

            monthCalendar1.Visible = true;
            monthCalendar1.Location = new System.Drawing.Point(
       txtfecha.Left,
       pictureBox1.Bottom
   );
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            // Actualizar el TextBox con la fecha seleccionada
            txtfecha.Text = monthCalendar1.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            monthCalendar1.Visible = false;

        }

        private void btncargar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (txtfecha.Text == "" || txtreferencia.Text == "" || txtmonto.Text == "0" || txtmonto.Text == "")
            {
                MaterialMessageBox.Show("Debe de llenar los campos obligatorios");
                return;
            }


            ListViewItem item = new ListViewItem(correlativo);

          //   this.clasificacioncuenta = cuentacon.GetcuentaClasificacion( Convert.ToInt32(cmbcuenta.SelectedValue) );


            item.SubItems.Add(txtfecha.Text);
            item.SubItems.Add(cmbcuenta.Text);
            item.SubItems.Add(cmblibro.Text);

            if (this.clasificacioncuenta == "Debito")
            {
                item.SubItems.Add(txtmonto.Text);
                item.SubItems.Add("0");
                debe = debe + Convert.ToInt32(txtmonto.Text);
            }
            else
            {
                item.SubItems.Add("0");
                item.SubItems.Add(txtmonto.Text);
                haber = haber + Convert.ToInt32(txtmonto.Text);

            }
            item.SubItems.Add(cmbcuenta.SelectedValue.ToString() );
            item.SubItems.Add( cmblibro.SelectedValue.ToString());
          

            if (haber != debe && ( haber != 0 && debe != 0 ) )
            {
                if (this.clasificacioncuenta == "Debito")
                {
           
                    debe = debe - Convert.ToInt32(txtmonto.Text);
                }
                else
                {
              
                    haber = haber - Convert.ToInt32(txtmonto.Text);

                }
                
                MaterialMessageBox.Show("La Partida no esta cuadrada");
            }
            else
            {
                lspartidas.Items.Add(item);
                txtmonto.Text = "";
            }
          

        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla de control (por ejemplo, Enter)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprimir la entrada
                e.Handled = true;
            }
        }

        private void lspartidas_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            using (Pen pen = new Pen(Color.Green))
            {
                e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            }
        }

        private void lspartidas_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Dibuja la línea vertical en azul
            using (Pen pen = new Pen(Color.Green))
            {
                e.Graphics.DrawLine(pen, e.Bounds.Right - 1, e.Bounds.Top, e.Bounds.Right - 1, e.Bounds.Bottom);
            }
        }

        private void btncargar_Click_1(object sender, EventArgs e)
        {

          

            foreach (ListViewItem item in lspartidas.Items)
            {
                partidamod.Asiento = Convert.ToInt32(item.SubItems[0].Text); // Suponiendo que la primera columna contiene el dato que deseas insertar
                partidamod.Fecha = Convert.ToDateTime(item.SubItems[1].Text); // Suponiendo que la segunda columna contiene otro dato
                partidamod.CuentaPar = Convert.ToInt32(item.SubItems[6].Text);
                partidamod.Parcial = 0;
                partidamod.Debe = Convert.ToInt32(item.SubItems[4].Text);
                partidamod.Haber = Convert.ToInt32(item.SubItems[5].Text);
                partidamod.Referencia = txtreferencia.Text;
                partidamod.ParIdEmpresa = 3;
                partidamod.ParIdLibro = Convert.ToInt32(item.SubItems[7].Text);
                partidamod.UsuarioCreacion = "yanoe01";
                partidamod.TipoTransaccion = "Partidas";

                partidacon.Crear(partidamod);
                lspartidas.Clear();

                lspartidas.Items.Clear();
               

            }

            correlamod.Descripcion = "Asiento";

            correlacon.Crear(correlamod);

            txtreferencia.Text = "";
            txtfecha.Text = "";


            MaterialMessageBox.Show("Se agrego exitosamente");


        }

        private void cmbcuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void cmbcuenta_SelectedValueChanged(object sender, EventArgs e)
        {
           
            DataRowView selectedRow = (DataRowView)cmbcuenta.SelectedItem;
            string nombre = selectedRow["Id"].ToString();

            if (string.IsNullOrEmpty(nombre))
            {
                // El ComboBox está vacío
                // Puedes mostrar un mensaje de error o tomar alguna acción apropiada.
            }
            else
            {
                this.clasificacioncuenta = cuentacon.GetcuentaClasificacion(Convert.ToInt32(nombre));

                swinaturaleza.Text = this.clasificacioncuenta;
                swinaturaleza.Checked = true;

                if (this.clasificacioncuenta == "Debito")
                {

                    swinaturaleza.Checked = true;

                }
                else
                {

                    swinaturaleza.Checked = false;

                }
            }

        
        }

        private void swinaturaleza_CheckedChanged(object sender, EventArgs e)
        {
            if ( swinaturaleza.Checked == true)
            {
                swinaturaleza.Text = "Debito";
                this.clasificacioncuenta = "Debito";
            }
            else
            {
                swinaturaleza.Text = "Credito";
                this.clasificacioncuenta = "Credito";
            }
        }
    }
}
