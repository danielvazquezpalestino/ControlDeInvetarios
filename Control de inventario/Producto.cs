using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_inventario
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

        public void AgregarProducto()
        {
            // Lógica para agregar un producto a la base de datos
        }

        public void ActualizarProducto()
        {
            // Lógica para actualizar un producto existente
        }

        public void EliminarProducto()
        {
            // Lógica para eliminar un producto
        }

        public Producto ObtenerProducto(int id)
        {
            // Lógica para obtener un producto por ID
            return new Producto();
        }
    }
}
