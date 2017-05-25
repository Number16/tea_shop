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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        
        public RegisterWindow()
        {
            InitializeComponent();
            try
            {
                User.UserList = User.ReadUsers(User.UserFile);
            } catch
            {
                MessageBox.Show("Список пользователей не найден, создание нового...");
                File.Create("../../data/u.txt");
            }
        }

       

        private void regLoginField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (regKeyField.Text == "" || regLoginField.Text == "" || regPasswordField.Text == "")
                {
                    MessageBox.Show("Заполните все поля");
                }
                else
                {
                    if (regKeyField.Text == "methylamine")
                    {
                        User.UserList.Add(new User(regLoginField.Text, regNameField.Text, regPasswordField.Text, true));
                    }
                    else
                    {
                        User.UserList.Add(new User(regLoginField.Text, regNameField.Text, regPasswordField.Text, false));
                    }
                    User.SaveData(User.UserFile, User.UserList);
                    MessageBox.Show("Пользователь добавлен");
                    this.Close();
                }
                
            } catch
            {
                MessageBox.Show("Проверьте корректность ввода");
            }
            
        }

        private void regNameField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void regPasswordField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void regKeyField_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
