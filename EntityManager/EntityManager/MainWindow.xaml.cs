using System.Windows;
using System.Windows.Navigation;
using System.ComponentModel;
using EntityManager.ViewModels;

namespace EntityManager
{
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; set; } = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Forward || e.NavigationMode == NavigationMode.Back)
            {
                e.Cancel = true;
            }
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            ViewModel.Content.Save();
        }
    }
}