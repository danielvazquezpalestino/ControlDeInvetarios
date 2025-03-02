

using BasesDeDatos;
using Entidades;

namespace Control_de_inventario
{
    public partial class FormularioProducto : Form
    {
        public FormularioProducto()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Precio = Convert.ToInt32(txtPrecio.Text);
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Imagen = "";
            producto.CategoriaID = Convert.ToInt32(txtCategoria.Text);
            producto.ProveedorID = Convert.ToInt32(txtProvedor.Text);


            ProductoDataSource productoDataSource = new ProductoDataSource();
            productoDataSource.GuardarProducto(producto);

        }

        private void picImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picImagen.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void FormularioProducto_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ProductoDataSource producto = new ProductoDataSource();
            List<Producto> productos = producto.ConsultarProducto();
            dataGridView1.DataSource = productos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
