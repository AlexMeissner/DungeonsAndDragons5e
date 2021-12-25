using System.Windows;
using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Controls
{
    public partial class MonsterCardControl : UserControl
    {
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
    }
}