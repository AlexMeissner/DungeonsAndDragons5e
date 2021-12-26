using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class ActionControl : UserControl
    {
        public static readonly DependencyProperty ActionsProperty = DependencyProperty.Register("Actions", typeof(ObservableCollection<MonsterAction>), typeof(ActionControl), new PropertyMetadata(default));

        public ObservableCollection<MonsterAction> Actions
        {
            get { return (ObservableCollection<MonsterAction>)GetValue(ActionsProperty); }
            set { SetValue(ActionsProperty, value); }
        }

        public ActionControl()
        {
            InitializeComponent();
        }
    }
}