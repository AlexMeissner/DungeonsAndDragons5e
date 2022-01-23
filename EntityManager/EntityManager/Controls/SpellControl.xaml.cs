using System;
using System.Windows;
using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class SpellControl : UserControl
    {
        public event EventHandler? Delete = null;
        public static readonly DependencyProperty SpellProperty = DependencyProperty.Register("Spell", typeof(SpellViewModel), typeof(SpellControl), new PropertyMetadata(default));

        public SpellViewModel Spell
        {
            get { return (SpellViewModel)GetValue(SpellProperty); }
            set { SetValue(SpellProperty, value); }
        }

        public SpellControl()
        {
            InitializeComponent();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            Delete?.Invoke(this, EventArgs.Empty);
        }
    }
}