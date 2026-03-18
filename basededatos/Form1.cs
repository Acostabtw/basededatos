using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace basededatos
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Server=127.0.0.1; Port=3306; Database=Curso; User ID=root; Password=;";
        public Form1()
        {
            InitializeComponent();
            VerificarConexion();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            // 3. Insertar datos en MySQL
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO registro (nombre, apellido, numero_telefono) VALUES (@nom, @ape, @tel)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    // Usamos parámetros para evitar inyección SQL
                    cmd.Parameters.AddWithValue("@nom", nombre_txt.Text);
                    cmd.Parameters.AddWithValue("@ape", apellido_txt.Text);
                    cmd.Parameters.AddWithValue("@tel", telefono_txt.Text);

                    cmd.ExecuteNonQuery();
                    CargarDatos();

                    // 4. Si se guarda en la BD, lo agregamos a la tabla visual (DataGrid)
                   // dataGridView_fila.Rows.Add(nombre_txt.Text, apellido_txt.Text, telefono_txt.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }

            // Limpieza de campos (tu código original)
            nombre_txt.Clear();
            apellido_txt.Clear();
            telefono_txt.Clear();
            nombre_txt.Focus();

            SystemSounds.Exclamation.Play();
        }

        /* private void Btn_agregar_Click(object sender, EventArgs e)
         {
             dataGridView_fila.Rows.Add(nombre_txt.Text, apellido_txt.Text, telefono_txt.Text);
             nombre_txt.Clear();
             apellido_txt.Clear();
             telefono_txt.Clear();
             nombre_txt.Focus();

             SystemSounds.Exclamation.Play();
         }*/


        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView_fila.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
                return;
            }

            // Obtenemos el nombre de la fila seleccionada
            string nombreAEliminar = dataGridView_fila.CurrentRow.Cells[0].Value.ToString();

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    // Borramos de la tabla 'usuarios' donde el nombre coincida
                    string query = "DELETE FROM registro WHERE nombre = @nom";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nom", nombreAEliminar);

                    cmd.ExecuteNonQuery();

                    // Si se borró en MySQL, lo quitamos de la vista
                    dataGridView_fila.Rows.Remove(dataGridView_fila.CurrentRow);
                    MessageBox.Show("Registro eliminado de la base de datos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void Btn_ver_Click(object sender, EventArgs e)
        {
            
            if (dataGridView_fila.Rows.Count > 0)
            {
                
                dataGridView_fila.Rows.Clear();
                Btn_ver.Text = "Ver registros"; 
                MessageBox.Show("Registros ocultados");
            }
            else
            {
                
                string passwordCorrecta = "1234";
                string claveIngresada = Microsoft.VisualBasic.Interaction.InputBox("Introduce la contraseña de administrador:", "Acceso Restringido", "");

                if (claveIngresada == passwordCorrecta)
                {
                    MessageBox.Show("Acceso concedido");
                    CargarDatos();
                    Btn_ver.Text = "Ocultar registros"; 
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta. Acceso denegado.");
                }
            }
        }

        private void CargarDatos()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT nombre, apellido, numero_telefono FROM registro";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dataGridView_fila.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView_fila.Rows.Add(row["nombre"], row["apellido"], row["numero_telefono"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void VerificarConexion()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    // Si logra abrirse:
                    lblStatus.Text = "Base de Datos: Conectada";
                    lblStatus.ForeColor = Color.DarkGreen;
                }
                catch (Exception)
                {
                    // Si falla:
                    lblStatus.Text = "Base de Datos: Desconectada";
                    lblStatus.ForeColor = Color.Red;
                }
            }
        }

    } // Esta es la llave que cierra la clase Form1 (NO LA BORRES)
}

        /* private void Btn_eliminar_Click(object sender, EventArgs e)
         {
             if (dataGridView_fila == null)
             {
                 MessageBox.Show("Escoge una");
                 return;

             }

             dataGridView_fila.Rows.Remove(dataGridView_fila.CurrentRow);
         }*/


