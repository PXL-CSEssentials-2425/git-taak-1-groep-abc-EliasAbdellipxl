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

namespace Kleurenpsychologie
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

        private void Rood_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = new SolidColorBrush(Colors.Red);
        }

        private void Rood_MouseLeave(object sender, MouseEventArgs e)
        {
            main.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Geel_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Geel_MouseLeave(object sender, MouseEventArgs e)
        {
            main.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Groen_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = new SolidColorBrush(Colors.Green);
        }

        private void Groen_MouseLeave(object sender, MouseEventArgs e)
        {
            main.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Blauw_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Blauw_MouseLeave(object sender, MouseEventArgs e)
        {
            main.Background = new SolidColorBrush (Colors.LightGray);
        }

        private void Rood_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Kleurcode.Text = "Rood: #FF0000";
            Informatie.Text = "Rood is de kleur van warmte";
        }

        private void Geel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Kleurcode.Text = "Geel: #FFFF00";
            Informatie.Text = "Geel is de kleur van levenslust";
        }

        private void Groen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Kleurcode.Text = "Groen: #008000";
            Informatie.Text = "Groen is de kleur van genezing";
        }

        private void Blauw_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Kleurcode.Text = "Blauw: #0000FF";
            Informatie.Text = "Blauw is de kleur van intelligentie";
        }
    }
}