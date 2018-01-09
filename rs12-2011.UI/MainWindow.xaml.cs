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
        Salon salon;
        public MainWindow()
        {
            InitializeComponent();
            //admin = new Administracija();
        }

        public void Init(Salon s)
        {
            salon = s;

            LogovanKorisnik.Text = "  "+ salon.UlogovaniKorisnik.Ime +"  " + salon.UlogovaniKorisnik.Prezime +" Korisnicko Ime: "+ salon.UlogovaniKorisnik.KorisnickoIme+"  ";
        }

        private void Magacin_Click(object sender, RoutedEventArgs e)
        {
            var window = new MagacinWindow();
            window.Init(salon);
            window.ShowDialog();

        }

        private void Akcija_Click(object sender, RoutedEventArgs e)
        {
            var window = new AkcijeWindow();
            window.Init(salon);
            window.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new NoviKorisnik();
            window.Init(this, salon);
            window.ShowDialog();
        }
    }

}
