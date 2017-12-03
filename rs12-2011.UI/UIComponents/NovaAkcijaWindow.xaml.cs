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
    /// Interaction logic for NovaAkcijaWindow.xaml
    /// </summary>
    public partial class NovaAkcijaWindow : Window
    {
        public NovaAkcijaWindow()
        {
            InitializeComponent();
        }

        public int Mode { get; set; }

        public void Init()
        {
            if(Mode == 1)
            {
                tbNaziv.IsReadOnly = true;
            }
        }

        private void DodajPopust_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == 0)
            {
                ((NovaAkcijaViewModel)DataContext).KreirajPopust();
            }
            else
            {
                ((IzmeniAkcijeViewModel)DataContext).KreirajPopust();
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == 0)
            {
                ((NovaAkcijaViewModel)DataContext).KreirajAkciju();
            }
            else
            {
                ((IzmeniAkcijeViewModel)DataContext).IzmeniAkciju();
            }

            this.Close();
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
