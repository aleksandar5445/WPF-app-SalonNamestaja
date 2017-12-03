using rs12_2011.model;
using rs12_2011.UI.UIComponents;
using rs12_2011.UI.ViewModel;
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

namespace rs12_2011.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Administracija admin;
        public MainWindow()
        {
            InitializeComponent();
            admin = new Administracija();
        }

        public void Init(Administracija administracija)
        {
            admin = administracija;

            LogovanKorisnik.Text = "  "+ admin.GetSalon().UlogovaniKorisnik.Ime +"  " + admin.GetSalon().UlogovaniKorisnik.Prezime +" Korisnicko Ime: "+ admin.GetSalon().UlogovaniKorisnik.KorisnickoIme+"  ";
        }

        private void Magacin_Click(object sender, RoutedEventArgs e)
        {
            var window = new MagacinWindow();
            window.Init(admin.GetSalon());
            window.ShowDialog();

        }

        private void Akcija_Click(object sender, RoutedEventArgs e)
        {
            var window = new AkcijeWindow();
            window.Init(admin.GetSalon());
            window.ShowDialog();
        }
    }

}
