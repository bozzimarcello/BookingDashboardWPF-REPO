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

namespace BookingDashboardWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Prenotazioni prenotazioni = new Prenotazioni();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = prenotazioni;
        }

        private void BtnAggiorna_Click(object sender, RoutedEventArgs e)
        {
            prenotazioni.Aggiorna();
            TxtStatistica1.Text = prenotazioni.Statistica1.ToString("N2");
            TxtStatistica2.Text = prenotazioni.Statistica2.ToString("N2");

            // DA SISTEMARE
            // Accrocchio ignorante per far aggiornare il grafico a linea e barre:
            // siccome l'aggiornamento avviene solo al ridimensionamento
            // della finestra, ogni volta che si preme il pulsante
            // si aumenta e si diminuisce di un pixel l'altezza della finestra
            // non funziona se la finestra è massimizzata
            var height = Application.Current.MainWindow.Height;
            Application.Current.MainWindow.Height = height+1;
            Application.Current.MainWindow.Height = height;
        }
    }
}