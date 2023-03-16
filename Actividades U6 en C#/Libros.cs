using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_U6_en_C_
{
    internal class Libros
    {
        // Clase para representar una película
        [Serializable]
        public class Libro 
        {
            public string Titulo { get; set; }
            public string Director { get; set; }
            public int Anio { get; set; }

            public Libro()
            {

            }

            public Libro(string titulo, string director, int anio)
            {
                Titulo = titulo;
                Director = director;
                Anio = anio;
            }

            public void Serializar(BinaryWriter escritor)
            {
                escritor.Write(Titulo);
                escritor.Write(Director);
                escritor.Write(Anio);
            }

            public void Deserializar(BinaryReader lector)
            {
                Titulo = lector.ReadString();
                Director = lector.ReadString();
                Anio = lector.ReadInt32();
            }

            public override string ToString()
            {
                return $"Título: {Titulo}\nDirector: {Director}\nAño: {Anio}\n";
            }
        }
    }
}
