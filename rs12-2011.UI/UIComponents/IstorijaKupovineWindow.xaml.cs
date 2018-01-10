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
    /// Interaction logic for IstorijaKupovineWindow.xaml
    /// </summary>
    public partial class IstorijaKupovineWindow : Window
    {
        public IstorijaKupovineWindow()
        {
            InitializeComponent();
        }

        public void Init(Salon s)
        {
            DataContext = new IstorijaKupovineViewModel(s);
        }
    }
}
