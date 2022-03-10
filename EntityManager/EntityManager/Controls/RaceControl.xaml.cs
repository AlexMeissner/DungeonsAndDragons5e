using System;
using System.Windows;
using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class RaceControl : UserControl
    {
        public event EventHandler? Delete = null;
        public static readonly DependencyProperty RaceProperty = DependencyProperty.Register("Race", typeof(RaceViewModel), typeof(RaceControl), new PropertyMetadata(default));

        public RaceViewModel Race
        {
            get { return (RaceViewModel)GetValue(RaceProperty); }
            set { SetValue(RaceProperty, value); }
        }

        public RaceControl()
        {
            InitializeComponent();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            Delete?.Invoke(this, EventArgs.Empty);
        }
    }
}