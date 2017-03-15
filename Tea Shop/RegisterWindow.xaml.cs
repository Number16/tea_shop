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
        string FileName = "userlist.txt";
        public RegisterWindow()
        {
            try
            {
                InitializeComponent();
                User.ReadUsers(FileName);
            } catch
            {
                MessageBox.Show("Ошибка загрузки файла");
            }
        }

       

        private void regLoginField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
