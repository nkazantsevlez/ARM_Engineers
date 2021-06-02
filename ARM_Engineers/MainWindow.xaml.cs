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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ARM_Engineers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Sklad_GroupBox.Visibility = Visibility.Collapsed;
            Kabinety_GroupBox.Visibility = Visibility.Collapsed;
            TechObsluzhivanie_GroupBox.Visibility = Visibility.Collapsed;
            Spisanie_GroupBox.Visibility = Visibility.Collapsed;

        }

        private void PopUpButton_Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void FullScreenButton_Click(object sender, RoutedEventArgs e)
        {
            if(WindowState==WindowState.Normal)
            {
                FullScreenButton.Content = "В окне";
                
                WindowState = WindowState.Maximized;
            }
            else
            {
                FullScreenButton.Content = "На весь экран";
                WindowState = WindowState.Normal;

            }
            

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = MenuListView.SelectedIndex;
            switch (index)
            {
                case 0: Sklad_GroupBox.Visibility = Visibility.Visible;
                    Kabinety_GroupBox.Visibility = Visibility.Collapsed;
                    TechObsluzhivanie_GroupBox.Visibility = Visibility.Collapsed; 
                    Spisanie_GroupBox.Visibility = Visibility.Collapsed;
                    break;
                case 1: Kabinety_GroupBox.Visibility = Visibility.Visible;
                    Sklad_GroupBox.Visibility = Visibility.Collapsed;
                    TechObsluzhivanie_GroupBox.Visibility = Visibility.Collapsed;
                    Spisanie_GroupBox.Visibility = Visibility.Collapsed; break;
                case 2:
                    Sklad_GroupBox.Visibility = Visibility.Collapsed;
                    Kabinety_GroupBox.Visibility = Visibility.Collapsed;
                    TechObsluzhivanie_GroupBox.Visibility = Visibility.Visible;
                    Spisanie_GroupBox.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    Sklad_GroupBox.Visibility = Visibility.Collapsed;
                    Kabinety_GroupBox.Visibility = Visibility.Collapsed;
                    TechObsluzhivanie_GroupBox.Visibility = Visibility.Collapsed;
                    Spisanie_GroupBox.Visibility = Visibility.Visible;
                    break;
                default: MessageBox.Show("Ошибка!"); break;
                   
            }

        }
    }
}
