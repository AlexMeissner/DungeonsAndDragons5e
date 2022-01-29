using System;
using System.Windows;
using EntityManager.ViewModels;

namespace EntityManager.Windows
{
    public partial class TraitCreationWindow : Window
    {
        public TraitViewModel? Trait { get; set; } // TODO: Remove '?'

        public TraitCreationWindow()
        {
            Trait = new TraitViewModel
            {
                GUID = Guid.NewGuid().ToString()
            };

            InitializeComponent();
        }

        public TraitCreationWindow(TraitViewModel trait)
        {
            Trait = DeepCopy.Create(trait);
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