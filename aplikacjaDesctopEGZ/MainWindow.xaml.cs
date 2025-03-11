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
        string maleLitery = "qwertyuuiopasdfghjklzxcvbnm";
        string litery = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string cyfry = "1234567890";
        string znakiSpecjalne = "!@#$%^&*()_+-=";
        char[] haslo;
        string haslo1 = "";

        Random random = new Random();

        ComboBoxItem stanowisko;



        int liczbaZnakow = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void zatwierdzBtn_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(ileZnakowText.Text, out liczbaZnakow);

            haslo = new char[liczbaZnakow];

            for(int i =0; i < liczbaZnakow; i++)
            {
                haslo[i] = maleLitery[random.Next(0, maleLitery.Length)];
            }

            
            if (czyMaleWIelkie.IsChecked == true)
            {
                for (int i = 0; i < liczbaZnakow; i++)
                {
                    haslo[i] = litery[random.Next(0, litery.Length)];
                }
            }
            
            if (czyCyfry.IsChecked == true)
            {
            
                for (int i = 0; i < liczbaZnakow; i++)
                {
                    if (i % 2 == 0 || haslo[i] == ' ')
                        haslo[i] = cyfry[random.Next(0, cyfry.Length)];
                }
            }
            
            if (czyZnakiSpecjalne.IsChecked == true)
            {
            
                for (int i = 0; i < liczbaZnakow; i++)
                {
                    if (i % 3 == 0 || haslo[i] == ' ')
                        haslo[i] = znakiSpecjalne[random.Next(0, znakiSpecjalne.Length)];
                }
            }

            haslo1 = "";

            for (int i = 0; i < haslo.Length; i++)
            {
                haslo1 += haslo[i].ToString();
            }

            MessageBox.Show(haslo1);

        }

        private void wyswietlBtn_Click(object sender, RoutedEventArgs e)
        {

            stanowisko = stanowiskoCombo.SelectedItem as ComboBoxItem;
            MessageBox.Show($"Dane pracownika: {imieText.Text} {nazwiskoText.Text} {stanowisko.Content} haslo: {haslo1}");
        }
    }


}