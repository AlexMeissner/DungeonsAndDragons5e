using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace EntityManager.Controls
{
    public partial class EditBoxListControl : UserControl
    {
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(List<string>), typeof(EditBoxListControl), new PropertyMetadata(default));

        public List<string> Data
        {
            get { return (List<string>)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        public EditBoxListControl()
        {
            InitializeComponent();
        }

        private void OnAddEntry(object sender, RoutedEventArgs e)
        {
            Data.Add(string.Empty);
        }
    }
}