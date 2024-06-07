using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Capitulo
    {
		private int numero;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

        public Capitulo()
        {
			Numero = 1;
			Nombre = "Montañas Azules";
        }

        public override string ToString()
        {
            return $"Capitulo {Numero}, Nombre: {Nombre}";
        }

    }
}
