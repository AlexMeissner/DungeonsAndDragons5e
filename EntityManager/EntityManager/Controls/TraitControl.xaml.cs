using System;
using System.Windows;
using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class TraitControl : UserControl
    {
        public event EventHandler? Delete = null;
        public static readonly DependencyProperty TraitProperty = DependencyProperty.Register("Trait", typeof(TraitViewModel), typeof(TraitControl), new PropertyMetadata(default));

        public TraitViewModel Trait
        {
            get { return (TraitViewModel)GetValue(TraitProperty); }
            set { SetValue(TraitProperty, value); }
        }

        public TraitControl()
        {
            InitializeComponent();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            Delete?.Invoke(this, EventArgs.Empty);
        }
    }
}