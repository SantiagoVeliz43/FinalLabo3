using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main
{
    public partial class FormBuscP : Form
    {
        public FormBuscP()
        {
            InitializeComponent();
            this.FormClosing += FormBuscP_FormClosing;
        }

        private void btBuscID_Click(object sender, EventArgs e)
        {
            lbMostrarPrID.Items.Clear();

            if (!int.TryParse(txbIngresoID.Text.Trim(), out int idBuscado) || idBuscado <= 0)
            {
                MessageBox.Show("Por favor, ingresá un ID válido (número positivo).");
                return;
            }

            using (var conexion = new SQLiteConnection($"Data Source={Main.RutaBaseDeDatos};Version=3;"))
            {
                conexion.Open();

                string query = "SELECT * FROM Productos WHERE Id = @id";
                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idBuscado);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            lbMostrarPrID.Items.Add($"ID: {lector["Id"]}");
                            lbMostrarPrID.Items.Add($"Nombre: {lector["Nombre"]}");
                            lbMostrarPrID.Items.Add($"Descripción: {lector["Descripcion"]}");
                            lbMostrarPrID.Items.Add($"Precio: ${lector["Precio"]}");
                            lbMostrarPrID.Items.Add($"Stock: {lector["Stock"]}");
                        }
                        else
                        {
                            lbMostrarPrID.Items.Add("Producto no encontrado.");
                        }
                    }
                }
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
