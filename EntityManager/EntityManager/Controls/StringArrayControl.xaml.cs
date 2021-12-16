using System.Windows;
using System.Windows.Controls;

namespace EntityManager.Controls
{
    public partial class StringArrayControl : UserControl
    {
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(string[]), typeof(StringArrayControl), new PropertyMetadata(default));

        public string Data
        {
            get { return (string)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        public StringArrayControl()
        {
            InitializeComponent();
        }
    }
}