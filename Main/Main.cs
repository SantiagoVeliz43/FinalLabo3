using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace Main
{
    public partial class Main : Form
    {
        public static Main Menu0;

        public Main()
        {
            InitializeComponent();
            Menu0 = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CrearBaseDeDatos();
        }

        public static string RutaBaseDeDatos => Path.Combine(Application.StartupPath, "productos.db");

        private void CrearBaseDeDatos()
        {
            if (!File.Exists(RutaBaseDeDatos))
            {
                SQLiteConnection.CreateFile(RutaBaseDeDatos);
            }

            using (var conexion = new SQLiteConnection($"Data Source={RutaBaseDeDatos};Version=3;"))
            {
                conexion.Open();

                string crearTabla = @"
                    CREATE TABLE IF NOT EXISTS Productos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nombre TEXT NOT NULL,
                        Descripcion TEXT,
                        Precio REAL NOT NULL,
                        Stock INTEGER NOT NULL
                    );";

                using (var comando = new SQLiteCommand(crearTabla, conexion))
                {
                    comando.ExecuteNonQuery();
                }

                string verificar = "SELECT COUNT(*) FROM Productos;";
                using (var comando = new SQLiteCommand(verificar, conexion))
                {
                    long cantidad = (long)comando.ExecuteScalar();

                    if (cantidad == 0)
                    {
                        string insertar = @"
                            INSERT INTO Productos (Nombre, Descripcion, Precio, Stock)
                            VALUES 
                            ('CocaCola', 'Sin azucar 1.5lt', 2800, 40),
                            ('Papas fritas QUENTO', 'Sabor jamon 350gr', 1750, 15),
                            ('VillaVicencio', 'Agua mineral 1lt', 1500, 20),
                            ('Chetos', 'Snacks de maíz sabor queso 300gr', 2500, 25);";

                        using (var insertCmd = new SQLiteCommand(insertar, conexion))
                        {
                            insertCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Base de datos creada exitosamente con productos de prueba.");
                    }
                    else
                    {
                        MessageBox.Show("Base de datos encontrada.");
                    }
                }
            }
        }

        private void btBusqId_Click(object sender, EventArgs e)
        {
            var form = new FormBuscP();
            form.Show();
            this.Hide();
        }

        private void btListarAllProd_Click(object sender, EventArgs e)
        {
            var form = new FormListP();
            form.Show();
            this.Hide();
        }

        private void btCrearProd_Click(object sender, EventArgs e)
        {
            var form = new FormCrearProd();
            form.Show();
            this.Hide();
        }

        private void btEditarProd_Click(object sender, EventArgs e)
        {
            var form = new FormEditP();
            form.Show();
            this.Hide();
        }

        private void btEliProd_Click(object sender, EventArgs e)
        {
            var form = new FormEliP();
            form.Show();
            this.Hide();
        }
      
        public static void VolverAlMenu(Form formActual)
        {
            formActual.Close();
            Menu0.Show();
            Menu0.BringToFront();
        }
       
        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
