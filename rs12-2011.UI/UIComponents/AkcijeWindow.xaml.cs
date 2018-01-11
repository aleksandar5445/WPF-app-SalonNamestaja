using rs12_2011.model;
using rs12_2011.UI.ViewModel;
using System.Windows;

namespace rs12_2011.UI.UIComponents
{
    /// <summary>
    /// Interaction logic for AkcijeWindow.xaml
    /// </summary>
    public partial class AkcijeWindow : Window
    {
        private AdministracijaAkcijeViewModel viewModel;
        private Salon salon;

        public AkcijeWindow()
        {
            InitializeComponent();
        }

        public void Init(Salon s)
        {
            viewModel = new AdministracijaAkcijeViewModel(s);
            DataContext = viewModel;
            salon = s;
        }

        private void NovaAkcija_Click(object sender, RoutedEventArgs e)
        {
            var window = new NovaAkcijaWindow() { DataContext = new NovaAkcijaViewModel(viewModel, salon), Mode = 0 };
            window.ShowDialog();
        }

        private void ObrisiAkcija_Click(object sender, RoutedEventArgs e)
        {
            var selektovan = (Akcija)AkcijeGrid.SelectedItem;

            if (selektovan != null)
            {
                viewModel.ObrisiAkciju(selektovan);
            }
        }

        private void IzmeniAkcija_Click(object sender, RoutedEventArgs e)
        {
            var selektovan = (Akcija)AkcijeGrid.SelectedItem;
            AkcijeGrid.UnselectAll();

            if (selektovan != null)
            {
                var window = new NovaAkcijaWindow() { DataContext = new IzmeniAkcijeViewModel(viewModel, selektovan), Mode = 1 };
                //window.Inicijalizacija();
                window.ShowDialog();
            }
        }

        private void AkcijeGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selected = (Akcija)AkcijeGrid.SelectedItem;

            if (selected != null)
            {
                viewModel.PostaviPopuste(selected);
            }
        }

        private void Izlaz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
