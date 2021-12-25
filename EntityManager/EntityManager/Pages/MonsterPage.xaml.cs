using System.Windows.Controls;
using EntityManager.Windows;
using EntityManager.ViewModels;

namespace EntityManager.Pages
{
    public partial class MonsterPage : UserControl
    {
        public MonstersViewModel ViewModel { get; set; } = new MonstersViewModel();

        public MonsterPage()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (sender is Border a)
            {
                Monster b = (Monster)a.DataContext;
                MonsterCreationWindow window = new(b);
                window.Show();
            }
        }
    }
}