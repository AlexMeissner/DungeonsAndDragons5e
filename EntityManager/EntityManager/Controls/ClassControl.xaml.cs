using System;
using System.Windows;
using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class ClassControl : UserControl
    {
        public event EventHandler? Delete = null;
        public static readonly DependencyProperty ClassProperty = DependencyProperty.Register("Class", typeof(ClassViewModel), typeof(ClassControl), new PropertyMetadata(default));

        public ClassViewModel Class
        {
            get { return (ClassViewModel)GetValue(ClassProperty); }
            set { SetValue(ClassProperty, value); }
        }

        public ClassControl()
        {
            InitializeComponent();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            Delete?.Invoke(this, EventArgs.Empty);
        }
    }
}