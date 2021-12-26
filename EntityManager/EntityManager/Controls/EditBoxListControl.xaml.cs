using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace EntityManager.Controls
{
    public partial class EditBoxListControl : UserControl
    {
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(ObservableCollection<string>), typeof(EditBoxListControl), new PropertyMetadata(default));

        public ObservableCollection<string> Data
        {
            get { return (ObservableCollection<string>)GetValue(DataProperty); }
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