using MaterialSkin.Controls;
using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.Controller
{
    internal class PartidaController
    {
        public PartidaController() { }


        public bool Crear(Partida Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute partidaadd " + Modelo.Asiento + " , '"
                        + Modelo.Fecha + "' , "
                        + Modelo.CuentaPar + " , "
                        + Modelo.Parcial + " , "
                        + Modelo.Debe + " , " +
                        Modelo.Haber + " , '"
                         + Modelo.Referencia + "' , " +
                          +Modelo.ParIdEmpresa + " , " +
                           +Modelo.ParIdLibro + " , '"
                           + Modelo.UsuarioCreacion + "' , '" 
                           +Modelo.TipoTransaccion + "'  " 
                        ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                 //   MaterialMessageBox.Show("Se agrego exitosamente");

                    Con.Close();
                }

                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

    }
}
