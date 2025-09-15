using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class FormEditP : Form
    {
        public FormEditP()
        {
            InitializeComponent();
            this.FormClosing += FormBuscP_FormClosing;
        }

        private void FormEditP_Load(object sender, EventArgs e)
        {
            tbName.Text = "Ingresar nuevo nombre";
            tbDesc.Text = "Ingresar nueva descripción";
            tbPrecio.Text = "Ingresar nuevo precio";
            tbStock.Text = "Ingresar nuevo stock";

            tbName.Enabled = false;
            tbDesc.Enabled = false;
            tbPrecio.Enabled = false;
            tbStock.Enabled = false;
            btGuardar.Enabled = false;

            tbName.Enter += TextBox_Enter;
            tbDesc.Enter += TextBox_Enter;
            tbPrecio.Enter += TextBox_Enter;
            tbStock.Enter += TextBox_Enter;

            tbName.Leave += TextBox_Leave;
            tbDesc.Leave += TextBox_Leave;
            tbPrecio.Leave += TextBox_Leave;
            tbStock.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && tb.Text.StartsWith("Ingresar"))
                tb.Text = "";
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender == tbName && string.IsNullOrWhiteSpace(tbName.Text))
                tbName.Text = "Ingresar nuevo nombre";

            if (sender == tbDesc && string.IsNullOrWhiteSpace(tbDesc.Text))
                tbDesc.Text = "Ingresar nueva descripción";

            if (sender == tbPrecio && string.IsNullOrWhiteSpace(tbPrecio.Text))
                tbPrecio.Text = "Ingresar nuevo precio";

            if (sender == tbStock && string.IsNullOrWhiteSpace(tbStock.Text))
                tbStock.Text = "Ingresar nuevo stock";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            lbProd.Items.Clear();

            if (!int.TryParse(tbIdProd.Text.Trim(), out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            string rutaDB = Path.Combine(Application.StartupPath, "productos.db");
            string connStr = $"Data Source={rutaDB};Version=3;";

            using (var conexion = new SQLiteConnection(connStr))
            {
                conexion.Open();
                string query = "SELECT * FROM Productos WHERE Id = @id";
                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            string prodInfo = $"ID: {lector["Id"]}, Nombre: {lector["Nombre"]}, Descripción: {lector["Descripcion"]}, Precio: {lector["Precio"]}, Stock: {lector["Stock"]}";
                            lbProd.Items.Add(prodInfo);
                            tbName.Enabled = true;
                            tbDesc.Enabled = true;
                            tbPrecio.Enabled = true;
                            tbStock.Enabled = true;
                            btGuardar.Enabled = true;

                            tbName.Text = "Ingresar nuevo nombre";
                            tbDesc.Text = "Ingresar nueva descripción";
                            tbPrecio.Text = "Ingresar nuevo precio";
                            tbStock.Text = "Ingresar nuevo stock";
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.");
                        }
                    }
                }
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdProd.Text.Trim(), out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            string nuevoNombre = tbName.Text.Trim();
            string nuevaDesc = tbDesc.Text.Trim();
            string nuevoPrecioTexto = tbPrecio.Text.Trim();
            string nuevoStockTexto = tbStock.Text.Trim();

            if (string.IsNullOrEmpty(nuevoNombre) ||
                string.IsNullOrEmpty(nuevaDesc) ||
                string.IsNullOrEmpty(nuevoPrecioTexto) ||
                string.IsNullOrEmpty(nuevoStockTexto))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(nuevoPrecioTexto, out decimal nuevoPrecio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            if (!int.TryParse(nuevoStockTexto, out int nuevoStock))
            {
                MessageBox.Show("Stock inválido.");
                return;
            }

            try
            {
                string rutaDB = Path.Combine(Application.StartupPath, "productos.db");
                using (var conexion = new SQLiteConnection($"Data Source={rutaDB};Version=3;"))
                {
                    conexion.Open();

                    string query = @"UPDATE Productos 
                             SET Nombre = @nombre, 
                                 Descripcion = @descripcion, 
                                 Precio = @precio, 
                                 Stock = @stock 
                             WHERE Id = @id";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@descripcion", nuevaDesc);
                        cmd.Parameters.AddWithValue("@precio", nuevoPrecio);
                        cmd.Parameters.AddWithValue("@stock", nuevoStock);
                        cmd.Parameters.AddWithValue("@id", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.");
                            lbProd.Items.Clear();

                            string consulta = "SELECT * FROM Productos WHERE Id = @id";
                            using (var cmdBuscar = new SQLiteCommand(consulta, conexion))
                            {
                                cmdBuscar.Parameters.AddWithValue("@id", id);
                                using (var lector = cmdBuscar.ExecuteReader())
                                {
                                    if (lector.Read())
                                    {
                                        string prodActualizado = $"ID: {lector["Id"]}, Nombre: {lector["Nombre"]}, Descripción: {lector["Descripcion"]}, Precio: {lector["Precio"]}, Stock: {lector["Stock"]}";
                                        lbProd.Items.Add(prodActualizado);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un producto con ese ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Main.VolverAlMenu(this);
        }

        private void FormBuscP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel)
            {
                Main.Menu0.Show();
                Main.Menu0.BringToFront();
            }
        }

    }
}
