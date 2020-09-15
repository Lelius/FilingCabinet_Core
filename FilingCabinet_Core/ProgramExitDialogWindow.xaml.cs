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

namespace FilingCabinet
{
    public partial class ProgramExitDialogWindow : Window
    {
        public ProgramExitDialogWindow()
        {
            InitializeComponent();
        }

        public void ClickButtonProgramExitDialogWindowYes(object sender, RoutedEventArgs eventArgs)
        {
            Application.Current.Shutdown();
        }

        public void ClickButtonProgramExitDialogWindowNo(object sender, RoutedEventArgs eventArgs)
        {
            this.Close();
        }
    }
}