using rs12_2011.model;
using rs12_2011.UI.ViewModel;
using System.Windows;

namespace rs12_2011.UI.UIComponents
{
    /// <summary>
    /// Interaction logic for NoviKorisnik.xaml
    /// </summary>
    public partial class NoviKorisnik : Window
    {
        public int Mode = 0; // 0-create Korisnik 1-EDIT
        Window parent;
        Salon salon;
        NoviKorisnikViewModel viewModel;

        public NoviKorisnik()
        {
            InitializeComponent();
            Closing += NoviKorisnik_Closing;
        }

        public void Inicijalizacija()
        {
            if (Mode == 1)
            {
                Korisnicko_ime.IsEnabled = false;
                this.Title = "Izmeni Korisnika";
                return;
            }
        }

        private void NoviKorisnik_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            parent.Show();
        }

        public void Init(Window p, Salon s)
        {
            parent = p;
            salon = s;

            viewModel = new NoviKorisnikViewModel(salon);
            DataContext = viewModel;
        }

        private void IzlazButton_Click(object sender, RoutedEventArgs e)
        {
            parent.Show();
            Close();
        }

        private void Novi_korisnik_Click(object sender, RoutedEventArgs e)
        {
            var valid = viewModel.Validacija(passwordBox1.Password, passwordBoxPonovo.Password);

            tbPoruka.Text = valid;

            if (string.IsNullOrEmpty(valid))
            {
                viewModel.KreirajKorisnika(passwordBox1.Password);

                parent.Show();
                Close();
            }
        }
    }
}
