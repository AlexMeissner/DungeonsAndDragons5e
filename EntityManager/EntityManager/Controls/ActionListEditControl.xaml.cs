using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace EntityManager.Controls
{
    public partial class ActionListEditControl : UserControl
    {
        public static readonly DependencyProperty ActionsProperty = DependencyProperty.Register("Actions", typeof(List<Data.Action>), typeof(ActionListEditControl), new PropertyMetadata(default));

        public List<Data.Action> Actions
        {
            get { return (List<Data.Action>)GetValue(ActionsProperty); }
            set { SetValue(ActionsProperty, value); }
        }
        public ActionListEditControl()
        {
            InitializeComponent();
        }

        private void OnAddEntry(object sender, RoutedEventArgs e)
        {
            Actions.Add(new Data.Action() { Name = string.Empty, Type = string.Empty, Description = string.Empty });
        }
    }
}
