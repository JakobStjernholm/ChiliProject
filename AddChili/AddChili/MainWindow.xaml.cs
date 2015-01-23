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
using AddChiliDataBase;

namespace AddChili
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBaseConnector dbo = new DataBaseConnector();
        public MainWindow()
        {
            InitializeComponent();
            dbo.GetChili();
        }

        private void AddChiliButton1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://chililovers.nu/");
        }

        private void ChiliColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
