using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string NombreProveedor { get; set; }
        public string NombreCategoria { get; set; }
        public int Cantidad { get; set;  }
        public decimal Total {get; set;}


        public Inventario(IDataReader reader)
        {
            ID = Convert.ToInt32(reader["ID"]);
            Nombre = reader["Nom_Producto"].ToString();
            Descripcion = reader["Descripcion"].ToString();
            Precio = Convert.ToDecimal(reader["Precio"]);
            NombreProveedor = reader["NombreProveedor"].ToString();
            NombreCategoria = reader["NombreCategoria"].ToString();
            Cantidad =Convert.ToInt32( reader["cantidad"]);
            Total = Convert.ToDecimal(reader["TOTAL"]);
        }
    }
}
