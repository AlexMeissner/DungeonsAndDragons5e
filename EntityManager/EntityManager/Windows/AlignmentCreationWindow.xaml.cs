using System;
using System.Windows;
using EntityManager.ViewModels;

namespace EntityManager.Windows
{
    public partial class AlignmentCreationWindow : Window
    {
        public AlignmentViewModel? Alignment { get; set; } // TODO: Remove '?'

        public AlignmentCreationWindow()
        {
            Alignment = new AlignmentViewModel
            {
                GUID = Guid.NewGuid().ToString()
            };

            InitializeComponent();
        }

        public AlignmentCreationWindow(AlignmentViewModel alignment)
        {
            Alignment = DeepCopy.Create(alignment);
            InitializeComponent();
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}