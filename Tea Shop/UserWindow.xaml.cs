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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }
        private void userGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void userGrid_Loaded(object sender, RoutedEventArgs e)
        {
            
            userGrid.ItemsSource = User.UserList;
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            User.UserList = userGrid.Items.Cast<User>().ToList();
            User.SaveData("u.txt", User.UserList);
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (userGrid.SelectedItem != null)
            {
                User.UserList.Remove(User.UserList[userGrid.SelectedIndex]);
                userGrid.Items.Refresh();
            }
        }
    }
}
