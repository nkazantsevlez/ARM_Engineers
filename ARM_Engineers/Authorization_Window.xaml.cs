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

namespace ARM_Engineers
{
    /// <summary>
    /// Логика взаимодействия для Authorization_Window.xaml
    /// </summary>
    public partial class Authorization_Window : Window
    {
        public Authorization_Window()
        {
            InitializeComponent();
        }

        private void Autorization_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
