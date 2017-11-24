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
    /// Interaction logic for NoviNamestajWindow.xaml
    /// </summary>
    public partial class NoviNamestajWindow : Window
    {
        public int Mode = 0; // 0 - create     1 - update
        public NoviNamestajWindow()
        {
            InitializeComponent();
        }

        public void Inicijalizacija()
        {
            if (Mode == 1)
            {
                tbSifra.IsEnabled = false;
                this.Title = "Izmeni namestaj";
                return;
            }

            this.Title = "Novi namestaj";
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == 0)
            {
                ((NoviNamestajViewModel)DataContext).KreirajNoviNamestaj();
            }

            ((IzmeniNamestajViewModel)DataContext).IzmeniNamestaj();

            this.Close();
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
