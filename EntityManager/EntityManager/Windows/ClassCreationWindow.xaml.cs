using System;
using System.Windows;
using EntityManager.ViewModels;

namespace EntityManager.Windows
{
    public partial class ClassCreationWindow : Window
    {
        public ClassViewModel? Class { get; set; } // TODO: Remove '?'

        public ClassCreationWindow()
        {
            Class = new ClassViewModel
            {
                GUID = Guid.NewGuid().ToString()
            };

            InitializeComponent();
        }

        public ClassCreationWindow(ClassViewModel _class)
        {
            Class = DeepCopy.Create(_class);
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