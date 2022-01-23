using System;
using System.Windows;
using EntityManager.ViewModels;

namespace EntityManager.Windows
{
    public partial class SpellCreationWindow : Window
    {
        public SpellViewModel? Spell { get; set; } // TODO: Remove '?'

        public SpellCreationWindow()
        {
            Spell = new SpellViewModel
            {
                GUID = Guid.NewGuid().ToString()
            };

            InitializeComponent();
        }

        public SpellCreationWindow(SpellViewModel spell)
        {
            Spell = DeepCopy.Create(spell);
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