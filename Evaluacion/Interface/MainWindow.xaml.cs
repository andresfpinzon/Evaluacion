using Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Capitulo capitulo;
        Repositorio<Usuario> Usuarios;
        Repositorio<Autor> Autores;
        Repositorio<Libro> Libros;
        Repositorio<Prestamo> Prestamos;


        public MainWindow()
        {
            InitializeComponent();
            Usuarios = new Repositorio<Usuario>();
            Autores = new Repositorio<Autor>();
            Libros = new Repositorio<Libro>();
            Prestamos = new Repositorio<Prestamo>();
            capitulo = new Capitulo();
        }

        private void BtnCapturar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RbtAutor.IsChecked == false && RbtPrestamo.IsChecked == false && RbtUsuario.IsChecked == false)
                {
                    MessageBox.Show($"por falvor seleccione el tipo de objeto");
                }
                else if (RbtUsuario.IsChecked == true)
                {
                    Usuario usuario = new Usuario(Convert.ToInt32(TxbId.Text), TxbNombre.Text, TxbEmail.Text);

                    Usuarios.AgregarElemento(usuario);
                }
                else if (RbtPrestamo.IsChecked == true)
                {
                    Prestamo prestamo = new Prestamo();
                    prestamo.IdU = Convert.ToInt32(TxbId.Text);
                    prestamo.IdL = Convert.ToInt32(TxbIdLibro.Text);
                    prestamo.FechaI = Convert.ToDateTime(DtpFechaI.Text);
                    prestamo.FechaF = Convert.ToDateTime(DtpFechaF.Text);
                    
                    Prestamos.AgregarElemento(prestamo);
                }
                else if (RbtAutor.IsChecked == true)
                {
                    List<Libro> libros = new List<Libro>();
                    Autor autor = new Autor(Convert.ToInt32(TxbId.Text), TxbNombre.Text, TxbEmail.Text, libros);
                    Autores.AgregarElemento(autor);

                    Libro libro = new Libro
                    {
                        IdL = Convert.ToInt32(TxbIdLibro.Text),
                        Titulo = TxbTitulo.Text,
                        Capitulo = capitulo
                    };
                    Libros.AgregarElemento(libro);
                    autor.Libros.Add(libro);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No debe dejar campos vacios", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMostrar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder datos = new StringBuilder();

            if (RbtUsuario.IsChecked == true)
            {
                foreach (var usuario in Usuarios.MostrarElemento())
                {
                    datos.AppendLine(usuario.ToString());
                }
            }
            else if (RbtAutor.IsChecked == true)
            {
                foreach (var autor in Autores.MostrarElemento())
                {
                    datos.AppendLine(autor.ToString());
                }
            }
            else if (RbtPrestamo.IsChecked == true)
            {
                foreach (var prestamo in Prestamos.MostrarElemento())
                {
                    datos.AppendLine(prestamo.ToString());
                }
            }

            MessageBox.Show(datos.ToString(), "Datos", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnLibros_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder datos = new StringBuilder();

            foreach (var libro in Libros.MostrarElemento())
            {
                datos.AppendLine(libro.ToString());
            }

            MessageBox.Show(datos.ToString(), "Libros", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        ////No alcanzamos a hacer la validacion de cual estaria disponible segun que rtb estuviera seleccionado
        //private void RbtUsuario_Checked(object sender, RoutedEventArgs e)
        //{
           
        //}

        //private void RbtAutor_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        //private void RbtPrestamo_Checked(object sender, RoutedEventArgs e)
        //{

        //}
    }
}