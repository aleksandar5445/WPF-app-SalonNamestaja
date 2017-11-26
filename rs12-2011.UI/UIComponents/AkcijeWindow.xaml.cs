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

        public AkcijeWindow()
        {
            InitializeComponent();
        }

        public void Init(Salon s)
        {
            viewModel = new AdministracijaAkcijeViewModel(s);
            DataContext = viewModel;
        }
    }
}
