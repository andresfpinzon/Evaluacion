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
                if (RbtAutor.IsChecked == false && RbtPrestamo.IsChecked == false && RbtUsuario.IsChecked == false )
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
                    Autor autor = new Autor(Convert.ToInt32(TxbId.Text),Libros = List<Libro>, TxbNombre.Text, TxbEmail.Text);

                    Usuarios.AgregarElemento(usuario);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("No debe dejar campos vacios","ERROR",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLibros_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}