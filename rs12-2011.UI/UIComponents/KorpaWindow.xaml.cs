using rs12_2011.model;
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
using System.Windows.Shapes;

namespace rs12_2011.UI.UIComponents
{
    /// <summary>
    /// Interaction logic for KorpaWindow.xaml
    /// </summary>
    public partial class KorpaWindow : Window
    {
        Salon salon;
        Window parent;
        KorpaViewModel viewModel;

        public KorpaWindow()
        {
            InitializeComponent();
        }

        public void Init(Salon s, Window p)
        {
            salon = s;
            parent = p;

            viewModel = new KorpaViewModel(salon);
            DataContext = viewModel;
        }

        private void btnIzbaciIzKorpe_Click(object sender, RoutedEventArgs e)
        {
            var selektovan = (Tuple<Namestaj, int>)KorpaGrid.SelectedItem;

            viewModel.IzbaciIzKorpe(selektovan.Item1);
        }

        private void btnKupi_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Da li ste sigurni da zelite da kupite navedene stavke?", "Potvrda kupovine", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                viewModel.Kupi();

                MessageBox.Show("Kupovina uspesno obavljena", "Kupovina uspesna", MessageBoxButton.OK, MessageBoxImage.Information);

                parent.Show();
                Close();
            }
        }

        private void Izlaz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

}
