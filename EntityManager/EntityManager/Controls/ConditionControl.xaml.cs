using System;
using System.Windows;
using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class ConditionControl : UserControl
    {
        public event EventHandler? Delete = null;
        public static readonly DependencyProperty ConditionProperty = DependencyProperty.Register("Condition", typeof(ConditionViewModel), typeof(ConditionControl), new PropertyMetadata(default));

        public ConditionViewModel Condition
        {
            get { return (ConditionViewModel)GetValue(ConditionProperty); }
            set { SetValue(ConditionProperty, value); }
        }

        public ConditionControl()
        {
            InitializeComponent();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            Delete?.Invoke(this, EventArgs.Empty);
        }
    }
}