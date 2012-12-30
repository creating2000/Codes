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

namespace Async_Lambda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            //                      async lambda expression
            startWorkButton.Click += async (sender, e) =>
            {
                SetGuiValues(false, "Work Started");
                await DoSomeWork();
                SetGuiValues(true, "Work Finished");
            };
        }

        private Task DoSomeWork()
        {
            return Task.Delay(3000);
        }

        private void SetGuiValues(bool buttonEnabled, string status)
        {
            startWorkButton.IsEnabled = buttonEnabled;
            workStartedTextBlock.Text = status;
        }
    }
}
