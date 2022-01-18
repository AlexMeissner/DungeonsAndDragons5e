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
    public partial class ConditionPage : Page
    {
        public ConditionsViewModel ViewModel => DataContext as ConditionsViewModel ?? new();

        public ConditionPage()
        {
            InitializeComponent();
        }

        private void OnAddCondition(object sender, RoutedEventArgs e)
        {
            ConditionCreationWindow window = new();

            if (window.ShowDialog() == true && window.Condition != null)
            {
                ViewModel.Conditions.Add(window.Condition);
                SortConditions();
            }
        }

        private void OnDeleteCondition(object sender, System.EventArgs e)
        {
            if (sender is ConditionControl control)
            {
                ConditionViewModel condition = (ConditionViewModel)control.DataContext;
                var result = MessageBox.Show(string.Format("Soll '{0}' wirklich gelöscht werden?", condition.Name), "Eintrag löschen", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    ViewModel.Conditions.Remove(condition);
                }
            }
        }

        private void OnEditCondition(object sender, MouseButtonEventArgs e)
        {
            if (sender is ConditionControl control)
            {
                ConditionViewModel condition = (ConditionViewModel)control.DataContext;
                ConditionCreationWindow window = new(condition);

                if (window.ShowDialog() == true && window.Condition != null)
                {
                    int index = ViewModel.Conditions.IndexOf(condition);
                    ViewModel.Conditions[index] = window.Condition;
                    SortConditions();
                }
            }
        }

        private void SortConditions()
        {
            ViewModel.Conditions = new ObservableCollection<ConditionViewModel>(ViewModel.Conditions.OrderBy(x => x.Name));
        }
    }
}