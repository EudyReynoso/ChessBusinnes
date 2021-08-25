using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using MaterialSkin.Controls;

namespace CapaDatos
{
    public class D_Producto: ConexionData
    {

        public DataTable ListaProudctos()
        {
            DataTable Listado = new DataTable();

            SqlCommand query = new SqlCommand("SP_SelectAllProducts", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = query.ExecuteReader();

            Listado.Load(dataReader);
            dataReader.Close();
            CerrarConexion();

            return Listado;
        }
        public void InsertarProducto(E_Producto producto)
        {
            SqlCommand command = new SqlCommand("SP_InsertProductos", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@NombreProducto", producto.Nombre);
            command.Parameters.AddWithValue("@Descripcion", producto.Descipcion);
            command.Parameters.AddWithValue("@Precio", producto.Precio);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }
        public void EliminarProducto(E_Producto producto)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_DeleteProductById", AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IDproducto", producto.IdProducto);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                CerrarConexion();
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Estos productos estan relacionados con alguna factura o orden, no lo puede eliminar");
            }
        }
        public void ActualizarProducto(E_Producto producto)
        {
            SqlCommand command = new SqlCommand("SP_UpdateProduct", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
            command.Parameters.AddWithValue("@NombrePorducto", producto.Nombre);
            command.Parameters.AddWithValue("@Descripcion", producto.Descipcion);
            command.Parameters.AddWithValue("@Precio", producto.Precio);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }
        public DataTable BuscarProductosPorNombres(string valor)
        {

            SqlCommand query = new SqlCommand("SP_GetProductoByName", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            query.Parameters.AddWithValue("@Buscar", valor);
            SqlDataReader dataReader = query.ExecuteReader();

            DataTable lista = new DataTable();

            lista.Load(dataReader);
           
            dataReader.Close();
            CerrarConexion();

            return lista;
        }
    }
}
