using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_F2(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F2)
            {
                if (int.TryParse(((sender as TextBox).Text), out int dato)) EdadError_TextBlock.Visibility = Visibility.Hidden;
                else EdadError_TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void TextBox_F1(object sender, KeyEventArgs e)
        {
            TextBox cuadro = (TextBox)sender;
            TextBlock hint = null;
            if (cuadro.Tag.Equals("name")) hint = NombreHint_TextBlock; 
            else hint = ApellidoHint_TextBlock;

            if (e.Key == Key.F1 && hint.Visibility == Visibility.Hidden) hint.Visibility = Visibility.Visible;
            else if (e.Key == Key.F1 && hint.Visibility == Visibility.Visible) hint.Visibility = Visibility.Hidden;
        }
    }
}
