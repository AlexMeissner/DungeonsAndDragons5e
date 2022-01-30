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
    public partial class ClassesPage : Page
    {
        public ClassesViewModel ViewModel => DataContext as ClassesViewModel ?? new();

        public ClassesPage()
        {
            InitializeComponent();
        }

        private void OnEditClass(object sender, MouseButtonEventArgs e)
        {
            if (sender is ClassControl control)
            {
                ClassViewModel _class = (ClassViewModel)control.DataContext;
                ClassCreationWindow window = new(_class);

                if (window.ShowDialog() == true && window.Class != null)
                {
                    int index = ViewModel.Classes.IndexOf(_class);
                    ViewModel.Classes[index] = window.Class;
                    SortClasses();
                }
            }
        }

        private void OnAddClass(object sender, RoutedEventArgs e)
        {
            ClassCreationWindow window = new();

            if (window.ShowDialog() == true && window.Class != null)
            {
                ViewModel.Classes.Add(window.Class);
                SortClasses();
            }
        }

        private void OnDelete(object sender, EventArgs e)
        {
            if (sender is TraitControl control)
            {
                ClassViewModel _class = (ClassViewModel)control.DataContext;
                var result = MessageBox.Show(string.Format("Soll '{0}' wirklich gelöscht werden?", _class.Name), "Eintrag löschen", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    ViewModel.Classes.Remove(_class);
                }
            }
        }

        private void SortClasses()
        {
            ViewModel.Classes = new ObservableCollection<ClassViewModel>(ViewModel.Classes.OrderBy(x => x.Name));
        }
    }
}