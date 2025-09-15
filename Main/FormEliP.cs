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
    public partial class FormEliP : Form
    {
        private string rutaDB = Path.Combine(Application.StartupPath, "productos.db");

        public FormEliP()
        {
            InitializeComponent();
            this.FormClosing += FormEliP_FormClosing;
            btEliminar.Enabled = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            lbProd.Items.Clear();

            if (!int.TryParse(tbIdProd.Text.Trim(), out int idBuscado))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            using (var conn = new SQLiteConnection($"Data Source={rutaDB};"))
            {
                conn.Open();

                string query = "SELECT * FROM Productos WHERE Id = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idBuscado);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader.GetString(1);
                            string descripcion = reader.GetString(2);
                            decimal precio = reader.GetDecimal(3);
                            int stock = reader.GetInt32(4);

                            btEliminar.Enabled = true;

                            string producto = $"ID: {idBuscado} | Nombre: {nombre} | Descripción: {descripcion} | Precio: ${precio} | Stock: {stock}";
                            lbProd.Items.Add(producto);
                        }
                        else
                        {
                            lbProd.Items.Add("Producto no encontrado.");
                            btEliminar.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdProd.Text.Trim(), out int idEliminar))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Está seguro que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection($"Data Source={rutaDB};"))
                {
                    conn.Open();

                    string query = "DELETE FROM Productos WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idEliminar);
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente.");
                            lbProd.Items.Clear();
                            tbIdProd.Clear();
                            btEliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un producto con ese ID.");
                        }
                    }
                }
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Main.VolverAlMenu(this);
        }

        private void FormEliP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel)
            {
                Main.Menu0.Show();
                Main.Menu0.BringToFront();
            }
        }
    }
}
