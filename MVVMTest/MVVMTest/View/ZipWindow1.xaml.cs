using MVVMTest.ViewModel;
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

namespace MVVMTest.View
{
    /// <summary>
    /// Interaction logic for ZipWindow1.xaml
    /// </summary>
    public partial class ZipWindow1 : Window
    {
        public ZipWindow1(ZipViewModel model)
        {
            InitializeComponent();
            //model.WarningHandler += delegate(object sender, MessageEventArgs e) { MessageBox.Show(e.Message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); };
            //model.CloseHandler += delegate(object sender, EventArgs e) { Close(); };
            DataContext = model;
        }
    }
}
