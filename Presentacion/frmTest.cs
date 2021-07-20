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
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Configuration;

namespace Presentacion
{

    public partial class frmTest : MaterialForm
    {
        private SqlConnection ConexionDB =
                new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringChessDB"].ConnectionString);
        public frmTest()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                SqlCommand Query = new SqlCommand("SP_SelectLoginUser", AbrirConexion());
                Query.CommandType = CommandType.StoredProcedure;

                Query.Parameters.AddWithValue("@NombreUser", txtNombreUser.Text);
                Query.Parameters.AddWithValue("@Contraseña", txtContrasena.Text);

                SqlDataReader dataReader = Query.ExecuteReader();

                if (dataReader.Read())
                {
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.Show();
                    dataReader.Close();

                    Query.Parameters.Clear();
                }
                else
                {
                    MaterialMessageBox.Show("No te encontramos en los usuarios");
                    dataReader.Close();
                }
            }
            catch(Exception e)
            {
                MaterialMessageBox.Show("Error con la base de datos" + e.Message);
            }

        }

        public SqlConnection AbrirConexion()
        {
            if (ConexionDB.State == ConnectionState.Closed)
            {
                ConexionDB.Open();
            }
            return ConexionDB;
        }
        public SqlConnection CerrarConexion()
        {
            if (ConexionDB.State == ConnectionState.Open)
            {
                ConexionDB.Close();
            }
            return ConexionDB;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
