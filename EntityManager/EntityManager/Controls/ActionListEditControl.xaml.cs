using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class ActionListEditControl : UserControl
    {
        public static readonly DependencyProperty ActionsProperty = DependencyProperty.Register("Actions", typeof(ObservableCollection<MonsterAction>), typeof(ActionListEditControl), new PropertyMetadata(default));

        public ObservableCollection<MonsterAction> Actions
        {
            get { return (ObservableCollection<MonsterAction>)GetValue(ActionsProperty); }
            set { SetValue(ActionsProperty, value); }
        }
        public ActionListEditControl()
        {
            InitializeComponent();
        }

        private void OnAddEntry(object sender, RoutedEventArgs e)
        {
            Actions.Add(new MonsterAction() { Name = string.Empty, Type = string.Empty, Description = string.Empty });
        }
    }
}
