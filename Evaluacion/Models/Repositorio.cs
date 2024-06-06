using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Repositorio<T>
    {
        public List<T> elementos { get; set; }

        public void AgregarElemento(T elemento) 
        { 
            this.elementos.Add(elemento);
        }

        public void EliminarElemento(T elemento)
        {
            this.elementos.Remove(elemento);
        }

        public List<T> MostrarElemento()
        {
            return new List<T>(this.elementos);
        }


    }
}
