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

        public NoviKorisnik()
        {
            InitializeComponent();
            Closing += NoviKorisnik_Closing;
        }

        private void NoviKorisnik_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            parent.Show();
        }

        public void Init(Window p, Salon s, int mode)
        {
            parent = p;
            salon = s;
            Mode = mode;

            if (Mode == 1)
            {
                Korisnicko_ime.IsEnabled = false;
                this.Title = "Izmeni Korisnika";
                btnKorisnik.Content = "Izmeni korisnika";
                DataContext = new IzmeniKorisnikaViewModel(salon, salon.UlogovaniKorisnik);
            }
            else
            {
                this.Title = "Novi Korisnik";
                btnKorisnik.Content = "Novi korisnik";
                DataContext = new NoviKorisnikViewModel(salon);
            }
        }

        private void IzlazButton_Click(object sender, RoutedEventArgs e)
        {
            parent.Show();
            Close();
        }

        private void Korisnik_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == 0)
            {
                var viewModel = (NoviKorisnikViewModel)DataContext;
                var valid = viewModel.Validacija(passwordBox1.Password, passwordBoxPonovo.Password);

                tbPoruka.Text = valid;

                if (string.IsNullOrEmpty(valid))
                {
                    viewModel.KreirajKorisnika(passwordBox1.Password);

                    parent.Show();
                    Close();
                }
            }
            else
            {
                var viewModel = (IzmeniKorisnikaViewModel)DataContext;
                viewModel.Lozinka = passwordBox1.Password;
                viewModel.IzmeniKorisnika();
                ((MainWindow)parent).InitKorisnik();
                parent.Show();
                Close();
            }
        }
    }
}
