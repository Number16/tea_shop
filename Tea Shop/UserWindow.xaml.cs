﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public void userGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        public void userGrid_Loaded(object sender, RoutedEventArgs e)
        {
            


            
            {
                try
                {
                    User.UserList = User.ReadUsers(User.UserFile);
                    userGrid.ItemsSource = User.UserList;
                }
                catch
                {
                    MessageBox.Show("Список пользователей не найден, создание нового...");
                    File.Create("../../data/u.txt");
                }
            }
        }



        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (userGrid.SelectedItem != null)
            {
                User.UserList.Remove(User.UserList[userGrid.SelectedIndex]);
                userGrid.Items.Refresh();
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            User.UserList = userGrid.Items.Cast<User>().ToList();
            User.SaveData(User.UserFile, User.UserList);
            MessageBox.Show("Данные успешно сохранены");
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void backUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
