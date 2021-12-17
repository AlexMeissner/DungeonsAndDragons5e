using System.Windows;
using System.Windows.Controls;
using EntityManager.Data;

namespace EntityManager.Controls
{
    public partial class HitInfoControl : UserControl
    {
        public static readonly DependencyProperty HitInfoProperty = DependencyProperty.Register("HitInfo", typeof(MonsterHitInfo), typeof(HitInfoControl), new PropertyMetadata(default));

        public MonsterHitInfo HitInfo
        {
            get { return (MonsterHitInfo)GetValue(HitInfoProperty); }
            set { SetValue(HitInfoProperty, value); }
        }

        public HitInfoControl()
        {
            InitializeComponent();
        }
    }
}