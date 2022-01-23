using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using EntityManager.Windows;
using EntityManager.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Pages
{
    public partial class SpellsPage : Page
    {
        public SpellsViewModel ViewModel => DataContext as SpellsViewModel ?? new();

        public SpellsPage()
        {
            InitializeComponent();
        }

        private void OnAddSpell(object sender, RoutedEventArgs e)
        {
            SpellCreationWindow window = new();

            if (window.ShowDialog() == true && window.Spell != null)
            {
                ViewModel.Spells.Add(window.Spell);
                SortSpells();
            }
        }

        private void OnEditSpell(object sender, MouseButtonEventArgs e)
        {
            if (sender is SpellControl control)
            {
                SpellViewModel spell = (SpellViewModel)control.DataContext;
                SpellCreationWindow window = new(spell);

                if (window.ShowDialog() == true && window.Spell != null)
                {
                    int index = ViewModel.Spells.IndexOf(spell);
                    ViewModel.Spells[index] = window.Spell;
                    SortSpells();
                }
            }
        }

        private void SortSpells()
        {
            ViewModel.Spells = new ObservableCollection<SpellViewModel>(ViewModel.Spells.OrderBy(x => x.Name));
        }

        private void OnDeleteSpell(object sender, EventArgs e)
        {
            if (sender is SpellControl control)
            {
                SpellViewModel spell = (SpellViewModel)control.DataContext;
                var result = MessageBox.Show(string.Format("Soll '{0}' wirklich gelöscht werden?", spell.Name), "Eintrag löschen", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    ViewModel.Spells.Remove(spell);
                }
            }
        }
    }
}