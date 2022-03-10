using System;
using System.Windows;
using EntityManager.ViewModels;

namespace EntityManager.Windows
{
    public partial class RaceCreationWindow : Window
    {
        public RaceViewModel? Race { get; set; } // TODO: Remove '?'

        public RaceCreationWindow()
        {
            Race = new RaceViewModel
            {
                GUID = Guid.NewGuid().ToString()
            };

            InitializeComponent();
        }

        public RaceCreationWindow(RaceViewModel race)
        {
            Race = DeepCopy.Create(race);
            InitializeComponent();
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}