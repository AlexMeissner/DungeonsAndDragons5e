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
    public partial class TraitsPage : Page
    {
        public TraitsViewModel ViewModel => DataContext as TraitsViewModel ?? new();

        public TraitsPage()
        {
            InitializeComponent();
        }

        private void OnEditTrait(object sender, MouseButtonEventArgs e)
        {
            if (sender is TraitControl control)
            {
                TraitViewModel trait = (TraitViewModel)control.DataContext;
                TraitCreationWindow window = new(trait);

                if (window.ShowDialog() == true && window.Trait != null)
                {
                    int index = ViewModel.Traits.IndexOf(trait);
                    ViewModel.Traits[index] = window.Trait;
                    SortTraits();
                }
            }
        }

        private void OnAddTrait(object sender, RoutedEventArgs e)
        {
            TraitCreationWindow window = new();

            if (window.ShowDialog() == true && window.Trait != null)
            {
                ViewModel.Traits.Add(window.Trait);
                SortTraits();
            }
        }

        private void OnDelete(object sender, EventArgs e)
        {
            if (sender is TraitControl control)
            {
                TraitViewModel trait = (TraitViewModel)control.DataContext;
                var result = MessageBox.Show(string.Format("Soll '{0}' wirklich gelöscht werden?", trait.Name), "Eintrag löschen", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    ViewModel.Traits.Remove(trait);
                }
            }
        }

        private void SortTraits()
        {
            ViewModel.Traits = new ObservableCollection<TraitViewModel>(ViewModel.Traits.OrderBy(x => x.Name));
        }
    }
}