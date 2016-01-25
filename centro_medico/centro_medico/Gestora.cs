using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centro_medico
{
    class Gestora
    {

        private string strConexion = Properties.Settings.Default.CentroMedicoConnectionString.ToString();
        public CentroMedicoDataSet ds = new CentroMedicoDataSet();

        public void HistorialxNombre(string nombre)
        {
            CentroMedicoDataSet.HistorialesDataTable udt = new CentroMedicoDataSet.HistorialesDataTable();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select * from Historiales where Historiales.usuario in(select NssUsuario from Usuarios where nombre = {0})", nombre);
            SqlConnection conexion = new SqlConnection(strConexion);
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.ToString(), conexion);
            adaptador.Fill(ds.Historiales);
            conexion.Close();
           
        }

        public CentroMedicoDataSet.CitasDataTable CitaxNombre(string nombre)
        {
            CentroMedicoDataSet.CitasDataTable udt = new CentroMedicoDataSet.CitasDataTable();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select * from Citas where usuario in(select NssUsuario from Usuarios where nombre={0})", nombre);
            SqlConnection conexion = new SqlConnection(strConexion);
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.ToString(), conexion);
            adaptador.Fill(udt);
            conexion.Close();
            return udt;
        }

        public CentroMedicoDataSet.CitasDataTable CitaxMedico(string medico)
        {
            CentroMedicoDataSet.CitasDataTable udt = new CentroMedicoDataSet.CitasDataTable();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select * from Citas where medico in(select idMedico from Medicos where nombre={0})", medico);
            SqlConnection conexion = new SqlConnection(strConexion);
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.ToString(), conexion);
            adaptador.Fill(udt);
            conexion.Close();
            return udt;
        }

        public CentroMedicoDataSet.CitasDataTable CitaxFecha(string fecha)
        {
            CentroMedicoDataSet.CitasDataTable udt = new CentroMedicoDataSet.CitasDataTable();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select * from Citas where fecha = {0})", fecha);
            SqlConnection conexion = new SqlConnection(strConexion);
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.ToString(), conexion);
            adaptador.Fill(udt);
            conexion.Close();
            return udt;
        }



    }
}
