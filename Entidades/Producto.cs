using System.Data;

namespace Entidades
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public int ProveedorID { get; set; }
        public int CategoriaID { get; set; }


        public Producto() { }
        public Producto(IDataReader reader)
        {
            Nombre = reader["Nombre"].ToString();
            CategoriaID = Convert.ToInt32(reader["CategoriaID"]);
            Descripcion = Convert.ToString(reader["Decripcion"]);
            ID = Convert.ToInt32(reader["ID"]);
            Imagen = Convert.ToString(reader["Imagen"]);
            Precio = Convert.ToDecimal(reader["Precio"]);
            ProveedorID = Convert.ToInt32(reader["ProveedorId"]);

        }


    }
}