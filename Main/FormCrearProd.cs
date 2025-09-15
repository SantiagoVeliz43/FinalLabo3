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
    public partial class FormCrearProd : Form
    {
        public FormCrearProd()
        {
            InitializeComponent();
            this.FormClosing += FormCrearProd_FormClosing;

            InicializarPlaceholders();
            AsignarEventosTextBox();
            cazabobos.Select();
        }

        private void InicializarPlaceholders()
        {
            tbNombreProd.Text = "Ingresar nombre del producto";
            tbDescProd.Text = "Ingresar descripción del producto";
            tbPrecioProd.Text = "Ingresar precio del producto";
            tbStockProd.Text = "Ingresar stock del producto";

            tbNombreProd.ForeColor = Color.Gray;
            tbDescProd.ForeColor = Color.Gray;
            tbPrecioProd.ForeColor = Color.Gray;
            tbStockProd.ForeColor = Color.Gray;
        }

        private void AsignarEventosTextBox()
        {
            tbNombreProd.GotFocus += TextBox_Enter;
            tbDescProd.GotFocus += TextBox_Enter;
            tbPrecioProd.GotFocus += TextBox_Enter;
            tbStockProd.GotFocus += TextBox_Enter;

            tbNombreProd.LostFocus += TextBox_Leave;
            tbDescProd.LostFocus += TextBox_Leave;
            tbPrecioProd.LostFocus += TextBox_Leave;
            tbStockProd.LostFocus += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox tb && tb.ForeColor == Color.Gray)
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb == tbNombreProd)
                    tb.Text = "Ingresar nombre del producto";
                else if (tb == tbDescProd)
                    tb.Text = "Ingresar descripción del producto";
                else if (tb == tbPrecioProd)
                    tb.Text = "Ingresar precio del producto";
                else if (tb == tbStockProd)
                    tb.Text = "Ingresar stock del producto";

                tb.ForeColor = Color.Gray;
            }
        }

        private void btCrearProd_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreProd.Text.Trim();
            string descripcion = tbDescProd.Text.Trim();
            string precioTexto = tbPrecioProd.Text.Trim();
            string stockTexto = tbStockProd.Text.Trim();

            if (EsPlaceholder(nombre) || EsPlaceholder(precioTexto) || EsPlaceholder(stockTexto))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            if (!decimal.TryParse(precioTexto, out decimal precio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            if (!int.TryParse(stockTexto, out int stock))
            {
                MessageBox.Show("Stock inválido.");
                return;
            }

            try
            {
                using (var conexion = new SQLiteConnection($"Data Source={Main.RutaBaseDeDatos};Version=3;"))
                {
                    conexion.Open();

                    string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock) VALUES (@nombre, @descripcion, @precio, @stock)";
                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@stock", stock);

                        comando.ExecuteNonQuery();
                        long nuevoId = conexion.LastInsertRowId;

                        MessageBox.Show($"Producto creado exitosamente con ID: {nuevoId}");
                    }
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message);
            }
        }

        private bool EsPlaceholder(string texto)
        {
            return string.IsNullOrWhiteSpace(texto) || texto.StartsWith("Ingresar ");
        }

        private void LimpiarCampos()
        {
            tbNombreProd.Text = "";
            tbDescProd.Text = "";
            tbPrecioProd.Text = "";
            tbStockProd.Text = "";

            InicializarPlaceholders();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Main.VolverAlMenu(this);
        }

        private void FormCrearProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel)
            {
                Main.Menu0.Show();
                Main.Menu0.BringToFront();
            }
        }
    }
}
