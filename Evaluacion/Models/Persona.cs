namespace Models
{
    public abstract class Persona
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}
        public Persona(string n, string e)
        {
            Nombre = n;
			Email = e;

        }
    }
}
