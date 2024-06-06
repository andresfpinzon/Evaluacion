using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Libro
    {
		private int idL;

		public int IdL
		{
			get { return idL; }
			set { idL = value; }
		}

		private string titulo;

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}

		private Capitulo capitulo;

		public Capitulo Capitulo
		{
			get { return capitulo; }
		}

		public void	AgregarCapitulo(Capitulo capitulo)
		{
			capitulo = new Capitulo();
		}

	}
}
