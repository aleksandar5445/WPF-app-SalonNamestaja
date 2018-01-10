using System.Windows;
using rs12_2011.UI.ViewModel;
using rs12_2011.UI.DataAccess;
using rs12_2011.model;

namespace rs12_2011.UI.UIComponents
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        //Administracija admin;
        DatabaseAccess db;
        Salon salon;
        LoginViewModel viewModel;

        public Login()
        {
            InitializeComponent();

            //admin = new Administracija();
            db = new DatabaseAccess();
            salon = db.GetSalon();

            viewModel = new LoginViewModel(salon);
            DataContext = viewModel;

            Closing += Login_Closing;
        }

        private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //admin.SnimiPodatke();
        }

        private void Novi_korisnik_Click(object sender, RoutedEventArgs e)
        {
            var window = new NoviKorisnik();
            window.Init(this, salon, 0);
            this.Hide();
            window.Show();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var uspesno = viewModel.LoginKorisnik(passwordBox.Password);

            if (uspesno)
            {
                salon.UlogovaniKorisnik = viewModel.TrenutniKorisnik(passwordBox.Password);

                var window = new MainWindow();
                window.Init(salon);
                this.Close();
                window.ShowDialog();
            }
            else
            {
                Poruka.Visibility = Visibility.Visible;
            }
        }
    }
}
