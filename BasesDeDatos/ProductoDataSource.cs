using Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BasesDeDatos
{
    public class ProductoDataSource
    {
        public void GuardarProducto(Producto producto)
        {
            SqlConnection sqlConnection = new SqlConnection(Coneccion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into Producto(Nombre, Descripcion, Precio, Imagen , ProveedorID , CategoriaID )  " +
                $"values ('{producto.Nombre}','{producto.Descripcion}','{producto.Precio}','{producto.Imagen}' ,'{producto.ProveedorID}'  ,'{producto.CategoriaID}')";
            cmd.ExecuteNonQuery();

        }

        public List<Producto> ConsultarProducto()
        {
            SqlConnection sqlConnection = new SqlConnection(Coneccion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from producto;";
            IDataReader reader = cmd.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            while (reader.Read())
            {
                productos.Add(new Producto()
                {
                    Nombre = reader["Nombre"].ToString(),
                    CategoriaID = Convert.ToInt32(reader["CategoriaID"]),
                    Descripcion = Convert.ToString(reader["Descripcion"]),
                    ID = Convert.ToInt32(reader["ID"]),
                    Imagen = Convert.ToString(reader["Imagen"]),
                    Precio = Convert.ToDecimal(reader["Precio"]),
                    ProveedorID = Convert.ToInt32(reader["ProveedorId"])
                });
            }

            return productos;




        }



        public void ActualizarProducto(Producto producto)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Coneccion.CadenaConexion))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                string query = "UPDATE Producto SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, " +
                               "Imagen = @Imagen, ProveedorID = @ProveedorID, CategoriaID = @CategoriaID WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);
                    cmd.Parameters.AddWithValue("@ProveedorID", producto.ProveedorID);
                    cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);
                    cmd.Parameters.AddWithValue("@ID", producto.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

            public Producto
    
    }

}
