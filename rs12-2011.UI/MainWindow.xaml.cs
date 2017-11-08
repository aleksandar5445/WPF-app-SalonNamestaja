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
    public partial class MainWindow : Window
    {
        private AdministracijaNamestajaViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new AdministracijaNamestajaViewModel(KreirajSalon());
            DataContext = viewModel;
        }

        private Salon KreirajSalon()
        {
            var salon = new Salon
            {
                Adresa = "Adresa1",
                Telefon = "telefon",
                Naziv = "Salon1"
            };

            Closing += MainWindow_Closing;

            salon.Magacin = Util.GenericSerializer.Deserialize<List<Namestaj>>("../../../rs12-2011.UI/bin/Debug/namestaj.xml");

            return salon;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Util.GenericSerializer.Serialize("../../../rs12-2011.UI/bin/Debug/namestaj.xml", viewModel.Magacin.ToList());
        }

        private void NoviNamestaj_Click(object sender, RoutedEventArgs e)
        {
            var window = new NoviNamestajWindow() { DataContext = new NoviNamestajViewModel(viewModel) };
            window.ShowDialog();
        }

        private void ObrisiNamestaj_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ObrisiNamestaj((Namestaj)MagacinGrid.SelectedItem);
        }

        private void IzmeniNamestaj_Click(object sender, RoutedEventArgs e)
        {
            var selektovan = (Namestaj)MagacinGrid.SelectedItem;

            if (selektovan != null)
            {
                var window = new NoviNamestajWindow() { DataContext = new IzmeniNamestajViewModel(viewModel, selektovan), Mode = 1 };
                window.Inicijalizacija();
                window.ShowDialog();
            }            
        }
    }
}
