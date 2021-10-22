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

namespace DataPassing
{
    public delegate void DataTransferDelegate(string data);

    public partial class MainWindow : Window
    {
        public DataTransferDelegate del;
        

        public MainWindow()
        {
            InitializeComponent();

            del += new DataTransferDelegate(PassData);
           
        }

        private void BtnOpenWindow_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow childWindow = new ChildWindow(del);
            childWindow.Show();
        }

        public void PassData(string data)
        {
            LblDisplay.Content = data;
           
        }
    }
}
