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
    public partial class AlignmentsPage : Page
    {
        public AlignmentsViewModel ViewModel => DataContext as AlignmentsViewModel ?? new();

        public AlignmentsPage()
        {
            InitializeComponent();
        }

        private void OnAddAlignment(object sender, RoutedEventArgs e)
        {
            AlignmentCreationWindow window = new();

            if (window.ShowDialog() == true && window.Alignment != null)
            {
                ViewModel.Alignments.Add(window.Alignment);
                SortAlignments();
            }
        }

        private void OnEditAlignment(object sender, MouseButtonEventArgs e)
        {
            if (sender is AlignmentControl control)
            {
                AlignmentViewModel alignment = (AlignmentViewModel)control.DataContext;
                AlignmentCreationWindow window = new(alignment);

                if (window.ShowDialog() == true && window.Alignment != null)
                {
                    int index = ViewModel.Alignments.IndexOf(alignment);
                    ViewModel.Alignments[index] = window.Alignment;
                    SortAlignments();
                }
            }
        }

        private void OnDeleteAlignment(object sender, EventArgs e)
        {
            if (sender is AlignmentControl control)
            {
                AlignmentViewModel alignment = (AlignmentViewModel)control.DataContext;
                var result = MessageBox.Show(string.Format("Soll '{0}' wirklich gelöscht werden?", alignment.Name), "Eintrag löschen", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    ViewModel.Alignments.Remove(alignment);
                }
            }
        }

        private void SortAlignments()
        {
            ViewModel.Alignments = new ObservableCollection<AlignmentViewModel>(ViewModel.Alignments.OrderBy(x => x.Name));
        }
    }
}