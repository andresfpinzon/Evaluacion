using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Autor: Persona
    {
        private int idA;

        public int IdA
        {
            get { return idA; }
            set { idA = value; }
        }

        public List<Libro> Libros { get; set; }

        public void EscribirLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public Autor(int id, string nombre, string email,List<Libro> libros ):base(nombre, email)
        {
            Libros = libros;   
        }

       
    }
}
