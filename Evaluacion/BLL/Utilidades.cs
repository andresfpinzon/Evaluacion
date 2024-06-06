namespace BLL
{
    public static class Utilidades
    {
        public static string CalcularDevolucion(DateTime fecha)
        {
            string retardo =" ";

            if (DateTime.Now <  fecha ) 
            {
                retardo = "Entregado a tiempo";
            }
            else
            {
                retardo = "La entrega tardia generara un retardo";
            }

            return retardo;
        }

    }
}
