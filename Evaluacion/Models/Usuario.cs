using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario : Persona, IRegistrable, IBuscable
    {
        private int idU;

        public int IdU
        {
            get { return idU; }
            set { idU = value; }
        }
        public Usuario(int id, string nombre, string email) : base(nombre, email)
        {
            IdU = id;
        }

        public string RegistrarUsuario()
        {
            return "algo";
        }

        public string EliminarUsuario()
        {
            return "algo";
        }

        public string EditarUsuario()
        {
            return "algo";
        }

        string IBuscable.BuscarPorTitulo()
        {
            return "algo";
        }

        string IBuscable.BuscarPorAutor()
        {
            return "algo";
        }
    }
}
