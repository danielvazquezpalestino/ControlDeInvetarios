using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string NumeroTelefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Domicilio { get; set; }
        public string NSS { get; set; }

        public Vendedor()
        {

        }
        public Vendedor(int ID, string nombre, string numeroTelefono, string correoElectronico, string domicilio, string NSS)
        {
            this.ID = ID;
            Nombre = nombre;
            NumeroTelefono = numeroTelefono;
            CorreoElectronico = correoElectronico;
            Domicilio = domicilio;
            this.NSS = NSS;
        }

        public void AgregarVendedor()
        {
            // Lógica para agregar un vendedor
        }
    }
}
