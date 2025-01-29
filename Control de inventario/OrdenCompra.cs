using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_inventario
{
    public class OrdenCompra
    {
        public int ID { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Total { get; set; }
        public int ProductoID { get; set; }
        public int UsuarioID { get; set; }
        public int VendedorID { get; set; }
        public int MetodoPagoID { get; set; }

        public void CrearOrden()
        {
            // Lógica para registrar una nueva orden de compra
        }

        public OrdenCompra ObtenerOrden(int id)
        {
            // Lógica para obtener una orden específica
            return new OrdenCompra();
        }
    }
}
