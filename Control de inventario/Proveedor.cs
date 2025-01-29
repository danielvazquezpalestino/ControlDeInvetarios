using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_inventario
{
    public class Proveedor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Domicilio { get; set; }

        public Proveedor()
        {

        }

        public  Proveedor(int ID, string nombre, string correoElectronico , string domicilio)
        {
            this.ID = ID;
            this.Nombre = nombre;
            this.CorreoElectronico = correoElectronico;
            this.Domicilio = domicilio;

        }
    }
}
