using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Control_de_inventario
{
    public partial class FormularioVendedor : Form
    {
        public FormularioVendedor()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("server=DESKTOP-3DIM3QO;database=controlInventario;integrated security=true;encrypt=false");

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
            Vendedor vendedor = new Vendedor
            {
                NSS = txtSeguroSocial.Text,
                CorreoElectronico = txtCorreo.Text,
                Domicilio = txtDomicilio.Text,
                Nombre = txtNombre.Text,
                NumeroTelefono = txtNumeroTelefono.Text
            };

            GuardarVendedor(vendedor);
        }

        private void GuardarVendedor(Vendedor vendedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-3DIM3QO;database=prueba;integrated security=true;encrypt=false"))
                {
                    connection.Open();

                    string query = @"INSERT INTO Vendedor (NSS, Correo_Electronico, Domicilio, Nombre, Num_Telefono) 
                                     VALUES (@NSS, @Correo_Electronico, @Domicilio, @Nombre, @Num_Telefono)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NSS", vendedor.NSS);
                        command.Parameters.AddWithValue("@Correo_Electronico", vendedor.CorreoElectronico);
                        command.Parameters.AddWithValue("@Domicilio", vendedor.Domicilio);
                        command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                        command.Parameters.AddWithValue("@Num_Telefono", vendedor.NumeroTelefono);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vendedor guardado correctamente.");

            vendedor.ID = Convert.ToInt32(txtID.Text);
            vendedor.NSS = txtSeguroSocial.Text;
            vendedor.CorreoElectronico = txtCorreo.Text;
            vendedor.Domicilio = txtDomicilio.Text;
            vendedor.Nombre = txtNombre.Text;
            vendedor.NumeroTelefono = txtNumeroTelefono.Text;

            // Llamar al método para guardar el vendedor en la base de datos
            GuardarVendedor(vendedor);
        }

        private void GuardarVendedor(Vendedor vendedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-3DIM3QO;database=controlInventario;integrated security=true;encrypt=false"))
                {
                    connection.Open();

                    // Consulta SQL para insertar un nuevo vendedor
                    string query = @"INSERT INTO Vendedores (ID, NSS, CorreoElectronico, Domicilio, Nombre, NumeroTelefono) 
                                     VALUES (@ID, @NSS, @CorreoElectronico, @Domicilio, @Nombre, @NumeroTelefono)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Añadir parámetros para evitar SQL Injection
                        command.Parameters.AddWithValue("@ID", vendedor.ID);
                        command.Parameters.AddWithValue("@NSS", vendedor.NSS);
                        command.Parameters.AddWithValue("@CorreoElectronico", vendedor.CorreoElectronico);
                        command.Parameters.AddWithValue("@Domicilio", vendedor.Domicilio);
                        command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                        command.Parameters.AddWithValue("@NumeroTelefono", vendedor.NumeroTelefono);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vendedor guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vendedor: " + ex.Message);
            }
        }


        private void btnMostar_Click(object sender, EventArgs e)
        {
            MostrarVendedores();
        }

        private void MostrarVendedores()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-3DIM3QO;database=controlInventario;integrated security=true;encrypt=false"))
                {
                    connection.Open();

                    // Consulta SQL para seleccionar todos los vendedores
                    string query = "SELECT * FROM Vendedores";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar el DataTable al DataGridView
                        dataGridViewVendedores.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los vendedores: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormularioVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor
            {
                ID = Convert.ToInt32(txtID.Text),
                NSS = txtSeguroSocial.Text,
                CorreoElectronico = txtCorreo.Text,
                Domicilio = txtDomicilio.Text,
                Nombre = txtNombre.Text,
                NumeroTelefono = txtNumeroTelefono.Text
            };

            ActualizarVendedor(vendedor);
        }

        private void ActualizarVendedor(Vendedor vendedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-3DIM3QO;database=controlInventario;integrated security=true;encrypt=false"))
                {
                    connection.Open();

                    // Consulta SQL para actualizar un vendedor
                    string query = @"UPDATE Vendedores 
                              SET NSS = @NSS, 
                                  CorreoElectronico = @CorreoElectronico, 
                                  Domicilio = @Domicilio, 
                                  Nombre = @Nombre, 
                                  NumeroTelefono = @NumeroTelefono 
                              WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Añadir parámetros
                        command.Parameters.AddWithValue("@ID", vendedor.ID);
                        command.Parameters.AddWithValue("@NSS", vendedor.NSS);
                        command.Parameters.AddWithValue("@CorreoElectronico", vendedor.CorreoElectronico);
                        command.Parameters.AddWithValue("@Domicilio", vendedor.Domicilio);
                        command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                        command.Parameters.AddWithValue("@NumeroTelefono", vendedor.NumeroTelefono);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vendedor actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el vendedor con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el vendedor: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            EliminarVendedor(id);
        }

        private void EliminarVendedor(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-3DIM3QO;database=controlInventario;integrated security=true;encrypt=false"))
                {
                    connection.Open();

                    // Consulta SQL para eliminar un vendedor
                    string query = "DELETE FROM Vendedores WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Añadir parámetros
                        command.Parameters.AddWithValue("@ID", id);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vendedor eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el vendedor con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el vendedor: " + ex.Message);
            }
        }

        private void FormularioVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDomicilio.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtSeguroSocial.Text) || string.IsNullOrEmpty(txtNumeroTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Vendedor vendedor = new Vendedor
            {
                ID = Convert.ToInt32(txtID.Text),
                NSS = txtSeguroSocial.Text,
                CorreoElectronico = txtCorreo.Text,
                Domicilio = txtDomicilio.Text,
                Nombre = txtNombre.Text,
                NumeroTelefono = txtNumeroTelefono.Text
            };

            ActualizarVendedor(vendedor);
        }


        private void ActualizarVendedor(Vendedor vendedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-3DIM3QO;database=prueba;integrated security=true;encrypt=false"))
                {
                    connection.Open();

                    string query = @"UPDATE Vendedor 
                                      SET NSS = @NSS, 
                                          Correo_Electronico = @Correo_Electronico, 
                                          Domicilio = @Domicilio, 
                                          Nombre = @Nombre, 
                                          Num_Telefono = @Num_Telefono 
                                      WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", vendedor.ID);
                        command.Parameters.AddWithValue("@NSS", vendedor.NSS);
                        command.Parameters.AddWithValue("@Correo_Electronico", vendedor.CorreoElectronico);
                        command.Parameters.AddWithValue("@Domicilio", vendedor.Domicilio);
                        command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                        command.Parameters.AddWithValue("@Num_Telefono", vendedor.NumeroTelefono);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vendedor actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el vendedor con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el vendedor: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            EliminarVendedor(id);
        }

        private void EliminarVendedor(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-3DIM3QO;database=prueba;integrated security=true;encrypt=false"))
                {
                    connection.Open();

                    string query = "DELETE FROM Vendedor WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vendedor eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el vendedor con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el vendedor: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtSeguroSocial.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtNumeroTelefono.Clear();
            textBox1.Clear();
        }

        private void dataGridViewVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVendedores_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dataGridViewVendedores.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridViewVendedores.SelectedRows[0];

                // Rellenar los TextBox con los datos de la fila seleccionada
                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtSeguroSocial.Text = selectedRow.Cells["NSS"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["CorreoElectronico"].Value.ToString();
                txtDomicilio.Text = selectedRow.Cells["Domicilio"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtNumeroTelefono.Text = selectedRow.Cells["NumeroTelefono"].Value.ToString();
            }
        }

        private void vendedorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewVendedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVendedores_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVendedores_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewVendedores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewVendedores.SelectedRows[0];

                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtSeguroSocial.Text = selectedRow.Cells["NSS"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["Correo_Electronico"].Value.ToString();
                txtDomicilio.Text = selectedRow.Cells["Domicilio"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtNumeroTelefono.Text = selectedRow.Cells["Num_Telefono"].Value.ToString();
            }
        }

        private void dataGridViewVendedores_SelectionChanged_2(object sender, EventArgs e)
        {
            if (dataGridViewVendedores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewVendedores.SelectedRows[0];

                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtSeguroSocial.Text = selectedRow.Cells["NSS"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["Correo_Electronico"].Value.ToString();
                txtDomicilio.Text = selectedRow.Cells["Domicilio"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtNumeroTelefono.Text = selectedRow.Cells["Num_Telefono"].Value.ToString();
            }
        }
    }
}
