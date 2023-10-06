using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Controller
{
    internal class TipoMonedaController
    {
        public TipoMonedaController() { }



        public DataTable GetipoMoneda()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showTipoMoneda", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;


        }

    }
}
