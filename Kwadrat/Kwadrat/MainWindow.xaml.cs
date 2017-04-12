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

namespace Kwadrat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtBok_TextChanged(object sender, TextChangedEventArgs e)
        {
            double bok;
            if (double.TryParse(txtBok.Text,out bok) && bok > 0)
            {
                txtPole.Text = Math.Pow(bok, 2.0).ToString();
                txtObwod.Text = (bok * 4).ToString();
                lblKomunikat.Content = String.Empty;
            }
            else
            {
                lblKomunikat.Content = "Wpsiz liczbę dodatnią";
            }
        }

        private void btnWyczysc_Click(object sender, RoutedEventArgs e)
        {
            txtPole.Text = String.Empty;
            txtObwod.Text = String.Empty;
            txtBok.Text = String.Empty;
            lblKomunikat.Content = "Wpisz wymiar bloku";
        }

        private void btnRysuj_Click(object sender, RoutedEventArgs e)
        {
            double bok;
            if (double.TryParse(txtBok.Text, out bok) && bok <= 3800)
            {
                Kwadrat.Height = bok;
                Kwadrat.Width = bok;
                SolidColorBrush color = (SolidColorBrush)new BrushConverter().ConvertFromString(cmbKolory.Text);
                Kwadrat.Stroke = color;
                Kwadrat.Fill = color;
                Kwadrat.Opacity = (cPol.IsChecked.Value) ? 0.5 : 1;
            }
            else
            {
                lblKomunikat.Content = "Brak danych lub zbyt duży bok";
            }
        }
    }
}
