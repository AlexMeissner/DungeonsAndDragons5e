using System;
using System.Windows;
using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class AlignmentControl : UserControl
    {
        public event EventHandler? Delete = null;
        public static readonly DependencyProperty AlignmentProperty = DependencyProperty.Register("Alignment", typeof(AlignmentViewModel), typeof(AlignmentControl), new PropertyMetadata(default));

        public AlignmentViewModel Alignment
        {
            get { return (AlignmentViewModel)GetValue(AlignmentProperty); }
            set { SetValue(AlignmentProperty, value); }
        }

        public AlignmentControl()
        {
            InitializeComponent();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            Delete?.Invoke(this, EventArgs.Empty);
        }
    }
}