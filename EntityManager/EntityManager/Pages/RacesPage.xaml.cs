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
    public partial class RacesPage : Page
    {
        public RacesViewModel ViewModel => DataContext as RacesViewModel ?? new();

        public RacesPage()
        {
            InitializeComponent();
        }

        private void OnEdit(object sender, MouseButtonEventArgs e)
        {
            if (sender is RaceControl control)
            {
                RaceViewModel race = (RaceViewModel)control.DataContext;
                RaceCreationWindow window = new(race);

                if (window.ShowDialog() == true && window.Race != null)
                {
                    int index = ViewModel.Races.IndexOf(race);
                    ViewModel.Races[index] = window.Race;
                    SortClasses();
                }
            }
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            RaceCreationWindow window = new();

            if (window.ShowDialog() == true && window.Race != null)
            {
                ViewModel.Races.Add(window.Race);
                SortClasses();
            }
        }

        private void OnDelete(object sender, EventArgs e)
        {
            if (sender is RaceControl control)
            {
                RaceViewModel race = (RaceViewModel)control.DataContext;
                var result = MessageBox.Show(string.Format("Soll '{0}' wirklich gelöscht werden?", race.Name), "Eintrag löschen", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    ViewModel.Races.Remove(race);
                }
            }
        }

        private void SortClasses()
        {
            ViewModel.Races = new ObservableCollection<RaceViewModel>(ViewModel.Races.OrderBy(x => x.Name));
        }
    }
}