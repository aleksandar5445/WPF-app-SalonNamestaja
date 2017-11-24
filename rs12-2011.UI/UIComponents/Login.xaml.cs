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
using System.Windows.Shapes;
using rs12_2011.model;
using rs12_2011.UI;
using System.Collections.ObjectModel;
using rs12_2011.UI.ViewModel;

namespace rs12_2011.UI.UIComponents
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Administracija admin;
        LoginViewModel viewModel;

        public Login()
        {
            InitializeComponent();

            admin = new Administracija();

            viewModel = new LoginViewModel(admin.GetSalon());
            DataContext = viewModel;

            Closing += Login_Closing;
        }

        private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            admin.SnimiPodatke();
        }

        private void Novi_korisnik_Click(object sender, RoutedEventArgs e)
        {
            var window = new NoviKorisnik();
            window.Init(this, admin.GetSalon());
            this.Hide();
            window.Show();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var uspesno = viewModel.LoginKorisnik(passwordBox.Password);

            if (uspesno)
            {
                var window = new MainWindow();
                window.Init(admin.GetSalon());
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
