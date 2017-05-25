using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tea_Shop
{
    /// <summary>
    /// Interaction logic for TeaWindow.xaml
    /// </summary>
    public partial class TeaWindow : Window
    {
        public TeaWindow()
        {
            InitializeComponent();
            try
            {
                Tea.TeaList = Tea.ReadTea(Tea.TeaFile);
                teaGrid.ItemsSource = null;
                teaGrid.ItemsSource = Tea.TeaList;
                if (User.IsAdmin == false)
                {
                    saveTeaButton.IsEnabled = false;
                    deleteTeaButton.IsEnabled = false;
                    callAddWindow.IsEnabled = false;
                    teaGrid.IsReadOnly = true;
                } else
                {
                    saveTeaButton.IsEnabled = true;
                    deleteTeaButton.IsEnabled = true;
                    callAddWindow.IsEnabled = true;
                    teaGrid.IsReadOnly = false;
                }
            }
            catch
            {
                MessageBox.Show("Каталог не найден, создание нового...");
                File.Create("../../data/t.txt");
            }
        }

        private void teaGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void teaGrid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void backTeaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveTeaButton_Click(object sender, RoutedEventArgs e)
        {
            Tea.TeaList = teaGrid.Items.Cast<Tea>().ToList();
            Tea.SaveData(Tea.TeaFile, Tea.TeaList);
            MessageBox.Show("Данные успешно сохранены");
        }

        private void deleteTeaButton_Click(object sender, RoutedEventArgs e)
        {

            if (teaGrid.SelectedItem != null)
            {
                Tea.TeaList.Remove(Tea.TeaList[teaGrid.SelectedIndex]);
                teaGrid.Items.Refresh();
            }
        }

        private void callAddWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AddTeaWindow addTeaWin = new AddTeaWindow();
            addTeaWin.Show();
        }
    }
}
