using System;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;
using EntityManager.Data;

namespace EntityManager.Windows
{
    public partial class MonsterCreationWindow : Window
    {
        public Monster Monster { get; set; }

        public MonsterCreationWindow()
        {
            Monster = new Monster
            {
                GUID = Guid.NewGuid().ToString()
            };

            InitializeComponent();
        }

        public MonsterCreationWindow(Monster monster)
        {
            Monster = monster;
            InitializeComponent();
        }

        private static readonly Regex NumberRegex = new("[^0-9]+");

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            e.Handled = NumberRegex.IsMatch(e.Text);
        }
    }
}