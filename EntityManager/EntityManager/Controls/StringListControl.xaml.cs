using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace EntityManager.Controls
{
    public partial class StringListControl : UserControl
    {
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(List<string>), typeof(StringListControl), new PropertyMetadata(default));

        public List<string> Data
        {
            get { return (List<string>)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        public StringListControl()
        {
            InitializeComponent();
        }
    }
}