using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using EntityManager.Data;

namespace EntityManager.Controls
{
    public partial class ActionControl : UserControl
    {
        public static readonly DependencyProperty ActionsProperty = DependencyProperty.Register("Actions", typeof(List<Action>), typeof(ActionControl), new PropertyMetadata(default));

        public List<Action> Actions
        {
            get { return (List<Action>)GetValue(ActionsProperty); }
            set { SetValue(ActionsProperty, value); }
        }

        public ActionControl()
        {
            InitializeComponent();
        }
    }
}