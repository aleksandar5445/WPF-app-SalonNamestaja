using rs12_2011.model;
using rs12_2011.UI.ViewModel;
using System.Windows;

namespace rs12_2011.UI.UIComponents
{
    /// <summary>
    /// Interaction logic for SalonEdit.xaml
    /// </summary>
    public partial class SalonEdit : Window
    {
        Salon salon;
        Window parent;
        SalonEditViewModel viewModel;

        public SalonEdit()
        {
            InitializeComponent();
        }

        public void Init(Window p, Salon s)
        {
            salon = s;
            parent = p;
            viewModel = new SalonEditViewModel(salon);
            DataContext = viewModel;
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            viewModel.IzmeniPodatkeSalona();
            parent.Show();
            Close();
        }

        private void btnIzadji_Click(object sender, RoutedEventArgs e)
        {
            parent.Show();
            Close();
        }
    }
}
