using System.Windows.Input;
using System.Windows.Controls;
using EntityManager.Windows;
using EntityManager.Controls;
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

        private void OnEditMonster(object sender, MouseButtonEventArgs e)
        {
            if (sender is MonsterCardControl control)
            {
                Monster monster = (Monster)control.DataContext;
                MonsterCreationWindow window = new(monster);

                if (window.ShowDialog() == true && window.Monster != null)
                {
                    int index = ViewModel.Monsters.IndexOf(monster);
                    ViewModel.Monsters[index] = window.Monster;
                }
            }
        }

        private void OnAddMonster(object sender, System.Windows.RoutedEventArgs e)
        {
            MonsterCreationWindow window = new();

            if (window.ShowDialog() == true && window.Monster != null)
            {
                ViewModel.Monsters.Add(window.Monster);
            }
        }
    }
}