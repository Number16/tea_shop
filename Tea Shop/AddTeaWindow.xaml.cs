using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddTeaWindow.xaml
    /// </summary>
    public partial class AddTeaWindow : Window
    {
        public AddTeaWindow()
        {
            InitializeComponent();
        }

        private void cancelTeaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addTeaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Tea t = new Tea(teaNameBox.Text, teaDescBox.Text, teaTypeBox.Text, Double.Parse(teaPriceBox.Text));
                Tea.TeaList.Add(t);
                Tea.SaveData(Tea.TeaFile, Tea.TeaList);
                this.Close();
                TeaWindow teaWin = new TeaWindow();
                teaWin.Show();
            } catch
            {
                MessageBox.Show("Проверьте корректность ввода");
            }
        }
    }
}
