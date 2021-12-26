using System;
using System.Windows;
using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class MonsterCardControl : UserControl
    {
        public event EventHandler? Delete = null;
        public static readonly DependencyProperty MonsterProperty = DependencyProperty.Register("Monster", typeof(Monster), typeof(MonsterCardControl), new PropertyMetadata(default));

        public Monster Monster
        {
            get { return (Monster)GetValue(MonsterProperty); }
            set { SetValue(MonsterProperty, value); }
        }

        public MonsterCardControl()
        {
            InitializeComponent();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            Delete?.Invoke(this, EventArgs.Empty);
        }
    }
}