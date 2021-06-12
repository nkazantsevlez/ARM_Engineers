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
            if (SearchPC_TextBox.Text != "")
            {
                int SearchValue = Convert.ToInt32(SearchPC_TextBox.Text);
                var FilterSearch = from b in context.pc_viewsearch where b.Inventory_Number == SearchValue select b;
                SearchPC_DataGrid.ItemsSource = null;
                SearchPC_DataGrid.ItemsSource = FilterSearch.ToList();
            }
            else
            {
                SearchPC_DataGrid.ItemsSource = context.pc_viewsearch.ToList();
            }
        }

        private void SearchCPU_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if(SearchCPU_TextBox.Text!="")
            {
                int SearchValue = Convert.ToInt32(SearchCPU_TextBox.Text);
                var FilterSearch = from b in context.cpu_view where b.Inventory_Number_CPU == SearchValue select b;
                SearchCPU_DataGrid.ItemsSource = null;
                SearchCPU_DataGrid.ItemsSource = FilterSearch.ToList();
            }
            else
            {
                SearchCPU_DataGrid.ItemsSource = context.cpu_view.ToList();
            }
        }

        private void SearchRAM_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchRAM_TextBox.Text != "")
            {
                int SearchValue = Convert.ToInt32(SearchRAM_TextBox.Text);
                var FilterSearch = from b in context.ram_view where b.Inventory_Number_RAM == SearchValue select b;
                SearchRAM_DataGrid.ItemsSource = null;
                SearchRAM_DataGrid.ItemsSource = FilterSearch.ToList();
            }
            else
            {
                SearchRAM_DataGrid.ItemsSource = context.ram_view.ToList();
            }
        }

        private void SearchPerifery_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchPerifery_TextBox.Text != "")
            {
                int SearchValue = Convert.ToInt32(SearchPerifery_TextBox.Text);
                var FilterSearch = from b in context.peripherals_view where b.Inventory_Number == SearchValue select b;
                SearchPerifery_DataGrid.ItemsSource = null;
                SearchPerifery_DataGrid.ItemsSource = FilterSearch.ToList();
            }
            else
            {
                SearchPerifery_DataGrid.ItemsSource = context.peripherals_view.ToList();
            }
        }

        private void SearchPrinters_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchPrinters_TextBox.Text != "")
            {
                int SearchValue = Convert.ToInt32(SearchPrinters_TextBox.Text);
                var FilterSearch = from b in context.printer_view where b.Inventory_Number == SearchValue select b;
                SearchPrinters_DataGrid.ItemsSource = null;
                SearchPrinters_DataGrid.ItemsSource = FilterSearch.ToList();
            }
            else
            {
                SearchPrinters_DataGrid.ItemsSource = context.printer_view.ToList();
            }
        }

        private void SearchCartridge_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchCartridge_TextBox.Text != "")
            {
                int SearchValue = Convert.ToInt32(SearchCartridge_TextBox.Text);
                var FilterSearch = from b in context.cartridge_view where b.Inventory_Number == SearchValue select b;
                SearchCartridge_DataGrid.ItemsSource = null;
                SearchCartridge_DataGrid.ItemsSource = FilterSearch.ToList();
            }
            else
            {
                SearchCartridge_DataGrid.ItemsSource = context.cartridge_view.ToList();
            }
        }

        private void SearchNetwork_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchNetwork_TextBox.Text != "")
            {
                int SearchValue = Convert.ToInt32(SearchNetwork_TextBox.Text);
                var FilterSearch = from b in context.network_devices_view where b.Inventory_Number == SearchValue select b;
                SearchNetwork_DataGrid.ItemsSource = null;
                SearchNetwork_DataGrid.ItemsSource = FilterSearch.ToList();
            }
            else
            {
                SearchNetwork_DataGrid.ItemsSource = context.network_devices_view.ToList();
            }

        }

        private void SearchOther_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchOther_TextBox.Text != "")
            {
                int SearchValue = Convert.ToInt32(SearchOther_TextBox.Text);
                var FilterSearch = from b in context.other_devices_view where b.Inventory_Number == SearchValue select b;
                SearchOther_DataGrid.ItemsSource = null;
                SearchOther_DataGrid.ItemsSource = FilterSearch.ToList();
            }
            else
            {
                SearchOther_DataGrid.ItemsSource = context.other_devices_view.ToList();
            }
        }
    }
}
