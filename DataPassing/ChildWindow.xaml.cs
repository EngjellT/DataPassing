using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataPassing
{
    /// <summary>
    /// Interaction logic for ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        public DataTransferDelegate dataTransferDelegate;

        public ChildWindow(DataTransferDelegate del)
        {
            InitializeComponent();

            dataTransferDelegate = del;
            
            

            InitCombo();
        }

        private void InitCombo()
        {
         
        }

      
        private void BTNsub_Click(object sender, RoutedEventArgs e)
        {
            dataTransferDelegate?.Invoke(txtFullN.Text.ToString());
            
        }
    }
}
