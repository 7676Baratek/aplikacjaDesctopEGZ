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

namespace aplikacjaDesctopEGZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string litery = "qwertyuuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        string cyfry = "1234567890";
        string znakiSpecjalne = "!@#$%^&*()_+-=";
        char[] haslo;

        Random random = new Random();

        

        

        int liczbaZnakow = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zatwierdzBtn_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(ileZnakowText.Text, out liczbaZnakow);

            haslo = new char[liczbaZnakow];

            /*for (int i = 0; i < liczbaZnakow; i++)
            {
                if (czyMaleWIelkie.IsChecked == true)
                {
                    haslo[i] += litery[random.Next(0, litery.Length)];
                }

                else if (czyCyfry.IsChecked == true)
                {
                    haslo[i] += cyfry[random.Next(0, cyfry.Length)];
                }
                else if (czyZnakiSpecjalne.IsChecked == true)
                {
                    haslo[i] += znakiSpecjalne[random.Next(0, znakiSpecjalne.Length)];
                }
                
            }*/

            if (czyMaleWIelkie.IsChecked == true)
            {
                for (int i = 0; i < liczbaZnakow; i++)
                {
                    haslo[i] += litery[random.Next(0, litery.Length)];
                }
            }

            if (czyCyfry.IsChecked == true)
            {
                for (int i = 1; i < liczbaZnakow; i+2)
                {
                    haslo[i] += cyfry[random.Next(0, cyfry.Length)];
                }
            }


            if (czyZnakiSpecjalne.IsChecked == true)
            {
                for (int i = 3; i < liczbaZnakow; i + 3)
                {
                    haslo[i] += cyfry[random.Next(0, cyfry.Length)];
                }
            }

        }

        

        private void ZatwierzBtn_Click(object sender, RoutedEventArgs e)
        {
            string haslo1 = "";

           for(int i = 0; i < haslo.Length;i++)
           {
                haslo1 += haslo[i].ToString();
           }

            MessageBox.Show($"Dane pracownika: {imieText.Text} {nazwiskoText.Text} haslo: {haslo1}");
        }
    }
}