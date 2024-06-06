using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Prestamo
    {
        public int IdU { get; set; }
        public int IdL { get; set; }

        private DateTime fechaI;

		public DateTime FechaI
		{
			get { return fechaI; }
			set { fechaI = value; }
		}

        private DateTime fechaF;

        public DateTime FechaF
        {
            get { return fechaF; }
            set { fechaF = value; }
        }

        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; }

        public override string ToString()
        {
            return $"El libro {Libro.Titulo} fue prestado el dia {FechaI} al usuario {Usuario.Nombre}" +
                $"este debe ser devuelto antes de {FechaF} ";
        }

        
    }
}
