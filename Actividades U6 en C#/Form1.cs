using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Actividades_U6_en_C_.Libros;

namespace Actividades_U6_en_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const string FILENAME = "peliculas.dat";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Crear un objeto de Libro a partir de la informacion ingresada por el usuario
                Libro Libro = new Libro(lblLibro.Text, txtDirector.Text, int.Parse(txtAño.Text));

                // Abrir el archivo binario para escritura (creando uno nuevo si no existe)
                using (FileStream archivo = new FileStream(FILENAME, FileMode.Append, FileAccess.Write))
                {
                    // Serializar el objeto de Libro y escribirlo en el archivo
                    BinaryWriter escritor = new BinaryWriter(archivo);
                    Libro.Serializar(escritor);
                }
                MessageBox.Show("El libro ha sido guardada correctamente.");
            }
            catch (FormatException)
            {
                MessageBox.Show("El año ingresado no es un número válido.");

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Se produjo un error al intentar guardar el libro: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir el archivo binario para lectura
                using (FileStream archivo = new FileStream(FILENAME, FileMode.Open, FileAccess.Read))
                {
                    // Leer el archivo y mostrar las películas guardadas
                    BinaryReader lector = new BinaryReader(archivo);
                    while (archivo.Position < archivo.Length)
                    {
                        Libro Libro = new Libro();
                        Libro.Deserializar(lector);
                        MessageBox.Show(Libro.ToString());
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se encontró el archivo de Libros.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al intentar leer el archivo de Libros: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
