using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using EntityManager.ViewModels;

namespace EntityManager.Windows
{
    public partial class MonsterCreationWindow : Window
    {
        public Monster? Monster { get; set; } // TODO: Remove '?'

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
            Monster = DeepCopy.Create(monster);
            InitializeComponent();
        }

        private static readonly Regex NumberRegex = new(@"[^0-9]+");
        private static readonly Regex DoubleRegex = new(@"^[0-9]+(.[0-9]*)?$");

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            e.Handled = NumberRegex.IsMatch(e.Text);
        }

        private void DoubleValidation(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                e.Handled = !DoubleRegex.IsMatch(textBox.Text.Insert(textBox.CaretIndex, e.Text));
            }
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

        private void OnChangeImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Image files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";

            if (dialog.ShowDialog() == true && Monster != null)
            {
                byte[] imageData = File.ReadAllBytes(dialog.FileName);
                Monster.Image = Convert.ToBase64String(imageData);
            }
        }
    }
}