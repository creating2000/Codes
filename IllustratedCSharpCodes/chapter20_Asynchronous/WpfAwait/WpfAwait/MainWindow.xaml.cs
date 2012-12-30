using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Set the cancel taken
        CancellationTokenSource _cancellationTokenSource;
        CancellationToken _cancellationToken;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        /// <summary>
        /// async method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnProcess_Click_1(object sender, RoutedEventArgs e)
        {
            // 1. Turn off the button
            btnProcess.IsEnabled = false;
            // 2. Initialize the CancellationTokenSource
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;

            // 3. Set the ProgressBar's value
            int completedPercent = 0;
            for (int i = 0; i < 100; i++)
            {
                // Stop the loop when you click the cancel button
                if (_cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                try
                {
                    // Await expression with Task.Delay()
                    await Task.Delay(100, _cancellationToken);
                    completedPercent = i;
                }
                catch (TaskCanceledException ex)
                {
                    completedPercent = i;
                }
                // Set the value of progressBar.
                progressBar.Value = completedPercent;
            }

            // 4. Set the message to pop-up
            string message = _cancellationToken.IsCancellationRequested ? string.Format("Process was cancelled at {0}%.", completedPercent) : "Process completed normally";
            MessageBox.Show(message, "Completion Status");
            // 5. Reset the status of main elements.
            progressBar.Value = 0;
            btnProcess.IsEnabled = true;
            btnCancel.IsEnabled = true;
        }

        /// <summary>
        /// Click the button to cancel the ProgressBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            // Cancel the process when the process is on.
            if (!btnProcess.IsEnabled)
            {
                btnCancel.IsEnabled = false;
                _cancellationTokenSource.Cancel();
            }
        }
    }
}
