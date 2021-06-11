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
    /// Логика взаимодействия для Search_Window.xaml
    /// </summary>
    public partial class Search_Window : Window
    {
        arm_engineersEntities context = new arm_engineersEntities();
        public Search_Window()
        {
            InitializeComponent();
            
            SearchPC_DataGrid.ItemsSource = context.pc_viewsearch.ToList();
            SearchCPU_DataGrid.ItemsSource = context.cpu_view.ToList();
            SearchRAM_DataGrid.ItemsSource = context.ram_view.ToList();
            SearchPerifery_DataGrid.ItemsSource = context.peripherals_view.ToList();
            SearchPrinters_DataGrid.ItemsSource = context.printer_view.ToList();
            SearchCartridge_DataGrid.ItemsSource = context.cartridge_view.ToList();
            SearchNetwork_DataGrid.ItemsSource = context.network_devices_view.ToList();
            SearchOther_DataGrid.ItemsSource = context.other_devices_view.ToList();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Search_TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchPC_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SearchCPU_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
