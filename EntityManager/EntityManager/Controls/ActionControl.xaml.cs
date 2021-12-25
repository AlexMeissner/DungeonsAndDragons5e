using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class ActionControl : UserControl
    {
        public static readonly DependencyProperty ActionsProperty = DependencyProperty.Register("Actions", typeof(List<MonsterAction>), typeof(ActionControl), new PropertyMetadata(default));

        public List<MonsterAction> Actions
        {
            get { return (List<MonsterAction>)GetValue(ActionsProperty); }
            set { SetValue(ActionsProperty, value); }
        }

        public ActionControl()
        {
            InitializeComponent();
        }
    }
}