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
    /// Логика взаимодействия для Employee_Window.xaml
    /// </summary>
    public partial class Employee_Window : Window
    {
        public Employee_Window()
        {
            InitializeComponent();
            OK_Cancel_DockPanel.Visibility = Visibility.Collapsed;
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            OK_Cancel_DockPanel.Visibility = Visibility.Visible;
            Edit_Button.Visibility=Visibility.Collapsed;
        }

        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {
            OK_Cancel_DockPanel.Visibility = Visibility.Collapsed;
            Edit_Button.Visibility = Visibility.Visible;
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            OK_Cancel_DockPanel.Visibility = Visibility.Collapsed;
            Edit_Button.Visibility = Visibility.Visible;
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
