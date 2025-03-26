﻿using BasesDeDatos;
using Entidades;
using Microsoft.Data.SqlClient; // Correcto para .NET 9
namespace Control_de_inventario
{
    public partial class formularioCarrito : Form
    {
        public formularioCarrito()
        {
            InitializeComponent();
        }
        int idseleccionado = 0;
        decimal precioSeleccionado = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBusquedaProducto.Text != "")
            {
                ProductoDataSource producto = new ProductoDataSource();
                List<Inventario> productos = producto.ConsultarProductoInformacion(txtBusquedaProducto.Text);
                dataGridView1.DataSource = productos;
                MessageBox.Show(producto.advertencia());


            }
            else
            {
                ProductoDataSource producto = new ProductoDataSource();
                List<Inventario> productos = producto.ConsultarProductocompleto();
                dataGridView1.DataSource = productos;
                MessageBox.Show(producto.advertencia());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void formularioCarrito_Load(object sender, EventArgs e)
        {
            CargarMetodosPagoEnComboBox();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idseleccionado != 0 && comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0 && precioSeleccionado != 0)
            {
                OrdenCompra orden = new OrdenCompra();
                orden.ProductoID = idseleccionado;
                orden.MetodoPagoID = comboBox1.SelectedIndex;
                orden.VendedorID = 1;
                orden.Total = precioSeleccionado;
                orden.FechaCompra = DateTime.Now;
                ProductoDataSource ordenes = new ProductoDataSource();
                ordenes.Guardarcarrito(orden, Convert.ToInt32(txtTotal.Text));
                MessageBox.Show("Se ah vendido correctamente");
                ordenes.ActualizarInventario(idseleccionado, Convert.ToInt32(txtTotal.Text));
            }
            else
            {
                MessageBox.Show("Seleccione un producto y un método de pago");
            }

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idseleccionado = 0;
            if (e.RowIndex >= 0)
            {
                // Obtén el valor del ID de la fila seleccionada
                idseleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                precioSeleccionado = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value);

                // Muestra el valor de 'ID' en un TextBox para poder actualizarlo

            }
        }
        
        private void CargarMetodosPagoEnComboBox()
        {
            // Limpiar el ComboBox antes de llenarlo
            comboBox1.Items.Clear();

            // Agregar un item predeterminado al ComboBox (opcional)
            comboBox1.Items.Add("Seleccione un método de pago");

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Coneccion.CadenaConexion))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT Forma FROM dbo.Metodo_Pago", sqlConnection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["Forma"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (mostrar mensaje, registrar error, etc.)
                MessageBox.Show($"Error al cargar métodos de pago: {ex.Message}");
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ProductoDataSource orden = new ProductoDataSource();
            List<OrdenCompra> ordenes = orden.ObtenerOrdenesCompra();
            dataGridView1.DataSource = ordenes;
        }
    }
}
