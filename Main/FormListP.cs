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

namespace Main
{
    public partial class FormListP : Form
    {
        public FormListP()
        {
            InitializeComponent();
            this.FormClosing += FormListP_FormClosing;
            this.Load += FormListP_Load;
        }

        private void FormListP_Load(object sender, EventArgs e)
        {
            lbListaProd.Items.Clear();

            using (var conexion = new SQLiteConnection($"Data Source={Main.RutaBaseDeDatos};Version=3;"))
            {
                conexion.Open();

                string query = "SELECT * FROM Productos";
                using (var comando = new SQLiteCommand(query, conexion))
                using (var reader = comando.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        lbListaProd.Items.Add("No hay productos cargados.");
                        return;
                    }

                    while (reader.Read())
                    {
                        string producto = $"{reader["Id"]} | {reader["Nombre"]} | {reader["Descripcion"]} | ${reader["Precio"]} | {reader["Stock"]}";
                        lbListaProd.Items.Add(producto);
                    }
                }
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Main.VolverAlMenu(this);
        }

        private void FormListP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel)
            {
                Main.Menu0.Show();
                Main.Menu0.BringToFront();
            }
        }
    }
}
