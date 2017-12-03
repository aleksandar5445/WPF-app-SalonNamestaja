using rs12_2011.model;
using rs12_2011.UI.ViewModel;
using System.Collections;
using System.Linq;
using System.Windows;

namespace rs12_2011.UI.UIComponents
{
    /// <summary>
    /// Interaction logic for MagacinWindow.xaml
    /// </summary>
    public partial class MagacinWindow : Window
    {
        ICollection view;

        private AdministracijaNamestajaViewModel viewModel;

        public MagacinWindow()
        {
            InitializeComponent();            
        }

        public void Init(Salon s)
        {
            viewModel = new AdministracijaNamestajaViewModel(s);
            DataContext = viewModel;
        }

        private void MagacinWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Util.GenericSerializer.Serialize("../../../rs12-2011.UI/bin/Debug/namestaj.xml", viewModel.Magacin.ToList());
        }

        private void NoviNamestaj_Click(object sender, RoutedEventArgs e)
        {
            var window = new NoviNamestajWindow() { DataContext = new NoviNamestajViewModel(viewModel), Mode = 0 };
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

//yourComboBox.ItemSource=enum.GetValues(typeof(effectstyle)).cast<effectstyle>();
//objectdataProvider