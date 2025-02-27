

using Entidades;

namespace Control_de_inventario
{
    public partial class FormularioVendedor : Form
    {
        public FormularioVendedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();

            vendedor.ID = Convert.ToInt32(txtID.Text);
            vendedor.NSS = txtSeguroSocial.Text;
            vendedor.CorreoElectronico = txtCorreo.Text;
            vendedor.Domicilio = txtDomicilio.Text;
            vendedor.Nombre = txtNombre.Text;
            vendedor.NumeroTelefono = txtNumeroTelefono.Text;
        }
    }
}
