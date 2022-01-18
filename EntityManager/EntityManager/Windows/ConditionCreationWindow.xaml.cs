using System;
using System.Windows;
using EntityManager.ViewModels;

namespace EntityManager.Windows
{
    public partial class ConditionCreationWindow : Window
    {
        public ConditionViewModel? Condition { get; set; } // TODO: Remove '?'

        public ConditionCreationWindow()
        {
            Condition = new()
            {
                GUID = Guid.NewGuid().ToString()
            };

            InitializeComponent();
        }

        public ConditionCreationWindow(ConditionViewModel condition)
        {
            Condition = DeepCopy.Create(condition);
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

        private void OnAddEffect(object sender, RoutedEventArgs e)
        {
            if (Condition != null)
            {
                Condition.Effects.Add(new());
            }
        }
    }
}