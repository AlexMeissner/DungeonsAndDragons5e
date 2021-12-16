using System.Windows;
using System.Windows.Controls;
using EntityManager.Data;

namespace EntityManager.Controls
{
    public partial class ActionControl : UserControl
    {
        public static readonly DependencyProperty ActionsProperty = DependencyProperty.Register("Actions", typeof(Action[]), typeof(ActionControl), new PropertyMetadata(default));

        public string Actions
        {
            get { return (string)GetValue(ActionsProperty); }
            set { SetValue(ActionsProperty, value); }
        }

        public ActionControl()
        {
            InitializeComponent();
        }
    }
}