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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tea_Shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                User.UserList = User.ReadUsers(User.UserFile);
            }
            catch
            {
                MessageBox.Show("Список пользователей не найден, создание нового...");
                File.Create("../../data/u.txt");
            }

        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow regWin = new RegisterWindow();
            regWin.Show();


        }

        public static bool isAdmin;


        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            bool found = false;
            
            for(int i = 0; i < User.UserList.Count; i++)
            {
                if (loginBox.Text == User.UserList[i].Login)
                {
                    if (passwordBox.Text == User.UserList[i].Password)
                    {
                        if (User.UserList[i].HasEditAccess == true)
                        {
                            found = true;
                            UserWindow teaWin = new UserWindow();
                            teaWin.Show();
                        } else
                        {
                            found = true;
                            MessageBox.Show("Нет доступа");
                        }
                    }  
                }
                
            }
            if(found == false)
            {
                MessageBox.Show("Неверные логин или пароль");
            }
        }

        private void loginBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void teaLoginButton_Click(object sender, RoutedEventArgs e)
        {
            TeaWindow teaWin = new TeaWindow();
            teaWin.Show();
        }
    }
}
